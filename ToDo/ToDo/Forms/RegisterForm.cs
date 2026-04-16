using ToDo.Forms;
using ToDo.global;
using ToDo.Model;

namespace ToDo
{
    public partial class RegisterForm : Form
    {
        private readonly AppDbContext _context;
        public RegisterForm()
        {
            InitializeComponent();
            _context = new AppDbContext();
        }
        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
           // Application.Exit();     
        }

        private void label7_Click(object sender, EventArgs e)
        {

            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
           // Application.Exit();

        }




        private async void Register_Click(object sender, EventArgs e)
        {
            if (ConfirmPass.Text != password.Text)
            {
                confirmPassValidation.Visible = true;
            }
            else
                confirmPassValidation.Visible = false;
            if (NameValidation.Visible || passwordValidation.Visible || confirmPassValidation.Visible)
            {
                MessageBox.Show("Please fix the validation errors before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }   

            User NewUser = new User
            {
                UserName = fullName.Text,
                Password = password.Text
            };  

            await _context.Users.AddAsync(NewUser);
            await _context.SaveChangesAsync();      
            CurrentUser.UserId = NewUser.UserId;
            CurrentUser.userName = NewUser.UserName;
            MainHomeForm mainHomeForm = new MainHomeForm();
            mainHomeForm.Show();
              this.Close();
           // Application.Exit();
        }


        private void fullName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fullName.Text) || fullName.Text.Length < 6)
            {
                NameValidation.Visible = true;
            }
            else
            {
                NameValidation.Visible = false;
            }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            if (password.Text.Length < 6 || !password.Text.Any(char.IsUpper) || !password.Text.Any(char.IsLower) || !password.Text.Any(char.IsDigit) || !password.Text.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                passwordValidation.Visible = true;
            }
            else
            {
                passwordValidation.Visible = false;
            }
        }




    }
}
