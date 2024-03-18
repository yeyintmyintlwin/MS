using System.Collections.Generic;

namespace MS
{
    public interface IDBOperations
    {
        void InsertUser(string username, string password, string fullname, string email);
        string GetUserPassword(string username);

        List<string> LoadProjects();
        
        /*
        void InsertProject(string projectName, string projectDescriptionr);
        void EditProject(string projectName, string projectDescriptionr);        
        void DeleteProject(string projectName);
        */
        //void InsertRequirement(string projectName, string requirementName, string requirementDescription, string requirementStatus, string requirementVersion);
        

    }
}
