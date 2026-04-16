using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDo.global;
using ToDo.Model;

namespace ToDo.Forms
{
    public partial class MainHomeForm : Form
    {
        private readonly AppDbContext _context;
        public MainHomeForm()
        {
            InitializeComponent();
            UserNameLabel.Text = CurrentUser.userName;
            _context = new AppDbContext();

            LoadData();
        }
        // category
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            categoryForm.Show();

            this.Close();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();

            this.Close();
        }

        // home
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MainHomeForm mainHomeForm = new MainHomeForm();
            mainHomeForm.Show();

            this.Close();
        }


        // todo
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            ToDoForm toDoForm = new ToDoForm(); 
            toDoForm.Show();    
            this.Close();
        }


        private void LoadData()
        {
            HomeDataGrid.Rows.Clear();
            var ReminderNotes = _context.Notes.Include(n => n.Category).
                Where(n => n.userId == CurrentUser.UserId &&
                n.isDeleted == false &&
                n.IsCompleted == false &&
                n.RemiderDate <= DateTime.Now 
              //  n.RemiderBeforeDays >= n.LastDate.Value.Day - DateTime.Now.Day)
                ).Select(n => new { title = n.Title, category = n.Category.Name, reminderDate = n.RemiderDate, lastDate = n.LastDate });

            foreach (var item in ReminderNotes)
            {
                HomeDataGrid.Rows.Add(item.title , item.category , item.reminderDate , item.lastDate);
            }
        }
    }
}
