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
                User userToSave = new User(fullName, username,  password);
                UserRepository repository = new UserRepository();
                bool isSaved = repository.Add(userToSave);
                if(isSaved)
                {
                    MessageBox.Show("User saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
               
                
            }

        }
    }
}

