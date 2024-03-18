using System.Collections.Generic;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MS
{
    public partial class MainMenuForm : Form
    {
        private IDBOperations db = new DB();
        private Size originalFormSize;
        
        public MainMenuForm()
        {
            InitializeComponent();
            originalFormSize = this.Size;
            ResponsiveForm.SetInitialSize(this);
        }
        public void UpdateUserNow()
        {
            //lbUser_Now.Text = "User: " + Program.user_name;
        }

        private void Project_Load(object sender, EventArgs e)
        {
            List<string> projectNames = db.LoadProjects();
            listBox1.Items.AddRange(projectNames.ToArray());
            
        }
    }
}
