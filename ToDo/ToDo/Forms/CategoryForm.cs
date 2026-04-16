using Microsoft.EntityFrameworkCore;
using Smart_Lawyer;
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
    public partial class CategoryForm : Form
    {
          private readonly AppDbContext _context;
      //  public event EventHandler AddNewCategory; 
        public CategoryForm()
        {
            InitializeComponent();
            _context = new AppDbContext();
            UserNameLabel.Text = CurrentUser.userName;
            loadData();
        }

        public void loadData()
        {
            CategoryDataGrid.Rows.Clear();
            var categories = _context.Categories.Where(u => u.userId == CurrentUser.UserId).Select(c => new { id = c.CategoryId, name = c.Name, countNotes = c.notes.Where(n=>n.isDeleted == false && n.IsCompleted == false).Count() });
            foreach (var category in categories)
            {
                CategoryDataGrid.Rows.Add(category.id, category.name, category.countNotes);
            }
        }
      

        private void AddCategory_Click(object sender, EventArgs e)
        {
            AddNewOrEditCategory addNewOrEditCategory = new AddNewOrEditCategory();
            addNewOrEditCategory.ShowDialog();

            loadData();
            // AddNewCategory.Invoke(this , EventArgs.Empty);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MainHomeForm mainHomeForm = new MainHomeForm();
            mainHomeForm.Show();

            this.Close();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();

            this.Close();
        }

        // category
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            categoryForm.Show();
            this.Close();
        }

        // todo
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            ToDoForm toDoForm = new ToDoForm();
            toDoForm.Show();
            this.Close();

        }

        private void CategoryDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // تأكد إن الضغط مش على الهيدر
            if (e.RowIndex < 0) return;


            if (CategoryDataGrid.Columns[e.ColumnIndex].Name == "delete")
            {
                int id = Convert.ToInt32(CategoryDataGrid.Rows[e.RowIndex].Cells["categoryId"].Value);

                Category? category = _context.Categories.SingleOrDefault(c=>c.CategoryId == id);
                if (category == null) return;
                _context.Categories.Remove(category);   
                _context.SaveChanges();              
                loadData();
            }


            if (CategoryDataGrid.Columns[e.ColumnIndex].Name == "edit")
            {
                int id = Convert.ToInt32(CategoryDataGrid.Rows[e.RowIndex].Cells["categoryId"].Value);

                Category? category = _context.Categories.SingleOrDefault(c => c.CategoryId == id);
                if (category == null) return;
                AddNewOrEditCategory addNewOrEditCategory = new AddNewOrEditCategory(category);
                addNewOrEditCategory.ShowDialog();

                loadData();
            }



            if (CategoryDataGrid.Columns[e.ColumnIndex].Name == "show")
            {
                int id = Convert.ToInt32(CategoryDataGrid.Rows[e.RowIndex].Cells["categoryId"].Value);

                Category? category = _context.Categories.SingleOrDefault(c => c.CategoryId == id);
                if (category == null) return;
                NotesInCategoryForm notesInCategoryForm = new NotesInCategoryForm(category);
                notesInCategoryForm.Show();
                this.Hide();
                loadData();
            }



        }
    }
}
