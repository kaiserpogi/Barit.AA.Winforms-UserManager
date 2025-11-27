namespace Barit.AA.Winforms_UserManager
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string fullName = txtboxFname.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(fullName)||string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);  
            }
            else
            {
                User userToSave = new User();
                userToSave.Username = username;
               userToSave.FullName = fullName;
                 userToSave.Password = password;

                UserRepository repository = new UserRepository();
                bool isSaved = repository.Add(userToSave);
                if(isSaved)
                {
                    MessageBox.Show("User saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtboxFname.Clear();
                    txtUsername.Clear();
                    txtPassword.Clear();   
                }
               
                
            }

        }
    }
}

