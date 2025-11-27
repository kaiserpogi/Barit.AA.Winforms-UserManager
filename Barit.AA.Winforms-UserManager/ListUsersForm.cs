using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barit.AA.Winforms_UserManager
{
    public partial class ListUsersForm : Form
    {
        UserRepository repository = new UserRepository();
        public ListUsersForm()
        {
            InitializeComponent();

            LoadUserToDataGridView();
        }

        private void LoadUserToDataGridView()
        {
            List<User> users = repository.GetAll();
            dgViewUsers.DataSource = users;
        }

        private void ListUsersForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to User Manager", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            addUserForm.ShowDialog();

        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            LoadUserToDataGridView();
        }
    }
}
