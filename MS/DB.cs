using MS;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

public class DB : IDBOperations
{
        // The connection string to the database
        private string connectionString = "datasource = localhost;port=3306;username=root;password=;database=ms;";
       
        public void ExecuteNonQuery(string sql, params MySqlParameter[] parameters)
        {
        using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddRange(parameters);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        
        
        public void ExecuteNonQuery(string sql, MySqlParameter[] parameters, MySqlConnection connection, MySqlTransaction transaction)
        {
            using (MySqlCommand cmd = new MySqlCommand(sql, connection, transaction))
            {
                cmd.Parameters.AddRange(parameters);
                cmd.ExecuteNonQuery();
            }
        }

        public void InsertUser(string username, string password, string fullname, string email)
        {
            string sql = "INSERT INTO user (username, password, fullname, email) VALUES (@Username, @Password, @Fullname, @Email)";
            MySqlParameter[] parameters = {
            new MySqlParameter("@Username", username),
            new MySqlParameter("@Password", password),
            new MySqlParameter("@fullname", fullname),
            new MySqlParameter("@Email", email)
            };
            ExecuteNonQuery(sql, parameters);
        }

        
        public string GetUserPassword(string username)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                String query = "select password from user where username = @Username";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Username", username);
                connection.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    return dr.GetString(0);
                }
                else
                {
                    return null;
                }
            }
        }

        public List<string> LoadProjects()
        {
            List<string> projectNames = new List<string>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                String query = "SELECT project_name FROM project";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                connection.Open();
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    projectNames.Add(dr.GetString(0));
                }
            }
            return projectNames;
        }
        public void InsertProject(string projectName, string projectDescription)
        {
            MySqlParameter[] parameters;
            string sql = "INSERT INTO projects (project_name, project_description) VALUES (@ProjectName, @ProjectDescription)";
            parameters = new MySqlParameter[]
            {
            new MySqlParameter("@ProjectName", projectName),
            new MySqlParameter("@ProjectDescription", projectDescription)
            };
            ExecuteNonQuery(sql, parameters);
        }
        public void UpdateProject(string projectName, string projectDescription)
        {
            MySqlParameter[] parameters;
            string sql = "UPDATE projects SET project_description = @ProjectDescription WHERE project_name = @ProjectName";
            parameters = new MySqlParameter[] 
            {
            new MySqlParameter("@ProjectName", projectName),
            new MySqlParameter("@ProjectDescription", projectDescription)
            };
            ExecuteNonQuery(sql, parameters);
        }

        public void DeleteProject(string projectName)
        {
            MySqlParameter[] parameters;
            string sql = "DELETE FROM projects WHERE project_name = @ProjectName";
            parameters = new MySqlParameter[]
            {
            new MySqlParameter("@ProjectName", projectName)
            };
            ExecuteNonQuery(sql, parameters);
        }

    public string GetProjectID(string projectName)
    {
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            try
            {
                string query = "SELECT project_id FROM project WHERE project_name = @project_name";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@project_name", projectName);
                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return reader["project_id"].ToString();
                }
                else
                {
                    throw new Exception("Project not found");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
    }

    public void InsertRequirement(string projectID, string requirementID, string requirementName, string requirementStatus, 
                                  string requirementVersion, bool isInsert, bool isDelete = false)
    {
        
       string sql;
       MySqlParameter[] parameters;
       sql = "INSERT INTO requirements(project_id, req_name, req_status, req_version, req_created at, req_updated at) values (@ProjectId, @RequirementName, @RequirementStatus, @RequirementVersion, @RequirementCreatedAt, @RequirementUpdatedAt)";
       parameters = new MySqlParameter[]
       {
        new MySqlParameter("@ProjectId", projectID),
        new MySqlParameter("@RequirementName", requirementName),
        new MySqlParameter("@RequirementStatus", requirementStatus),
        new MySqlParameter("@RequirementVersion", requirementVersion),
        new MySqlParameter("@RequirementCreatedAt", DateTime.Now),
        new MySqlParameter("@RequirementUpdatedAt", DateTime.Now)
       };
       ExecuteNonQuery(sql, parameters);
            
    }

    public void DeleteRequirement(string projectID, string requirementID, string requirementName, string requirementStatus,
                                  string requirementVersion, bool isInsert, bool isDelete = false)
    {
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            connection.Open();
            using (MySqlTransaction transaction = connection.BeginTransaction())
            {
                try
                {
                    string insertHistoryQuery = "INSERT INTO version history (project_id, req_id, req_name, req_status, req_version, req_updated at, req_created at) SELECT project_id, req_id, req_name, req_status, req_version, req_updated at, req_created at FROM requirement WHERE req_id = @RequirementID";
                    using (MySqlCommand insertHistoryCmd = new MySqlCommand(insertHistoryQuery, connection))
                    {
                        insertHistoryCmd.Parameters.AddWithValue("@RequirementID", requirementID);
                        insertHistoryCmd.ExecuteNonQuery();
                    }

                    string deleteQuery = "UPDATE requirement SET IsDeleted = true, req_updated at = @RequirementUpdatedAt WHERE req_id = @RequirementID";
                    MySqlParameter[] deleteParameters = new MySqlParameter[]
                    {
                            new MySqlParameter("@RequirementID", requirementID),
                            new MySqlParameter("@RequirementUpdatedAt", DateTime.Now)
                    };
                    ExecuteNonQuery(deleteQuery, deleteParameters, connection, transaction);

                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
    }

    private string IncreaseVersionNumber(string currentVersion)
    {
        int versionNumber = int.Parse(currentVersion);
        versionNumber++;
        return versionNumber.ToString();
    }

    public void UpdateRequirement(string projectID, string requirementID, string requirementName, string requirementStatus,
                                  string requirementVersion, bool isInsert, bool isDelete = false)
    {
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            string versionQuery = "select requirement_version from requirements where requirement_id = @RequirementID";
            MySqlCommand versionCmd = new MySqlCommand(versionQuery, connection);
            versionCmd.Parameters.AddWithValue("@RequirementID", requirementID);
            connection.Open();
            string currentVersion = versionCmd.ExecuteScalar().ToString();
            connection.Close();
            string newVersion = IncreaseVersionNumber(currentVersion);

            string insertHistoryQuery = "INSERT INTO requirements_history (requirement_id, requirement_name, requirement_status, requirement_version, requirement_updated_at, project_id, requirement_description, requirement_created_at) SELECT requirement_id, requirement_name, requirement_status, requirement_version, requirement_updated_at, project_id, requirement_description, requirement_created_at FROM requirements WHERE requirement_id = @RequirementID";
            MySqlCommand insertHistoryCmd = new MySqlCommand(insertHistoryQuery, connection);
            insertHistoryCmd.Parameters.AddWithValue("@RequirementID", requirementID);
            connection.Open();
            insertHistoryCmd.ExecuteNonQuery();
            connection.Close();

            string sql;
            MySqlParameter[] parameters;
            sql = "UPDATE requirements SET requirement_status = @RequirementStatus, requirement_version = @RequirementVersion, requirement_updated_at = @RequirementUpdatedAt WHERE requirement_id = @RequirementID";
            parameters = new MySqlParameter[]
            {
               // new MySqlParameter("@RequirementDescription", requirementDescription),
                    new MySqlParameter("@RequirementStatus", requirementStatus),
                    new MySqlParameter("@RequirementVersion", newVersion),
                    new MySqlParameter("@RequirementUpdatedAt", DateTime.Now),
                    new MySqlParameter("@RequirementID", requirementID)
            };
            ExecuteNonQuery(sql, parameters);
        }
    }
}

