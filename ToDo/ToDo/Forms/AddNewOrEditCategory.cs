using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDo.Forms;
using ToDo.global;
using ToDo.Model;

namespace Smart_Lawyer
{
    public partial class AddNewOrEditCategory : Form
    {
        private readonly AppDbContext _context;
        private Category? _category;
        public AddNewOrEditCategory(Category category = null)
        {
            InitializeComponent();
            _category = category; 
            _context = new AppDbContext();

            if (_category != null)
            {
                CategoryName.Text = _category.Name;     
            }

        }

        // clothing
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // save
        private async void guna2Button1_Click(object sender, EventArgs e)
        {

            if (_category == null)
            {
                if (string.IsNullOrEmpty(CategoryName.Text))
                    return;
                Category category = new Category();
                category.Name = CategoryName.Text;
                category.userId = CurrentUser.UserId;

                await _context.Categories.AddAsync(category);
                await _context.SaveChangesAsync();
                CategoryName.Text = string.Empty;
                succsess.Text = "added success";
                succsess.Visible = true;
            }
            else
            {
                _category.Name = CategoryName.Text;
                _context.Categories.Update(_category);
                await  _context.SaveChangesAsync();
                CategoryName.Text = string.Empty;
                succsess.Text = "updated success";
                succsess.Visible = true;
            }

        }


        private void CategoryName_TextChanged(object sender, EventArgs e)
        {
            succsess.Visible = false;
        }

    }
}
