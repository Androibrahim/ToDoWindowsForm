using Microsoft.EntityFrameworkCore;
using ToDo.Forms;
using ToDo.global;
using ToDo.Model;

namespace ToDo
{
    public partial class LoginForm : Form
    {
        private readonly AppDbContext _context;
        public LoginForm()
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

            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
              this.Hide();
           
        }

        private void Login_Click(object sender, EventArgs e)
        {
          
            User? user = _context.Users.SingleOrDefault(u => u.UserName == fullName.Text); // exeption no such table user 
            if (user != null)
            {
                if (user.Password == password.Text)
                {
                    CurrentUser.UserId = user.UserId;
                    CurrentUser.userName = user.UserName;
                    MainHomeForm mainHomeForm = new MainHomeForm();
                    mainHomeForm.Show();
                    this.Hide();
                }
                else
                    NameAndPassValidation.Visible = true;

            }
            else
                NameAndPassValidation.Visible = true;
            
        }

        private void guest_Click(object sender, EventArgs e)
        {
            CurrentUser.UserId = _context.Users.SingleOrDefault(u => u.UserName == "guest").UserId;
            CurrentUser.userName = _context.Users.SingleOrDefault(u => u.UserName == "guest").UserName;
            MainHomeForm mainHomeForm = new MainHomeForm();
            mainHomeForm.Show();
            this.Hide();
        }
    }
}
