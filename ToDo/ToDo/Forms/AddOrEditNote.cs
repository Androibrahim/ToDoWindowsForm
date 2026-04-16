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
    public partial class AddOrEditNote : Form
    {
        private readonly AppDbContext _context;
        private Category _category;
        private Note? _note; 
        public AddOrEditNote(Category category, Note note = null)
        {
            InitializeComponent();
            _context = new AppDbContext();
            _category = category;
            _note = note;



            
            if (_note != null)
            {
                title.Text = _note.Title;
                priority.Value = _note.priority ;
                reminderDate.Value = _note.RemiderDate ?? DateTime.Now;
                endDate.Value = _note.LastDate ?? DateTime.Now;
                remindBeforeEnd.Value = _note.RemiderBeforeDays ?? 0;
                content.Text = _note.Content;
            }
        }

        private void title_TextChanged(object sender, EventArgs e)
        {
            succeed.Visible = false;
            if (string.IsNullOrEmpty(title.Text))
            {
                titleValidation.Visible = true;
            }
            else
            {
                titleValidation.Visible = false;
            }
        }



        //save
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (_note == null)
            {
                if (priority.Value < 0 || priority.Value > 5)
                {
                    MessageBox.Show($"priority must betwwen 0 and 5 ");
                    return;
                }


                if (reminderDate.Value < DateTime.Now)
                {
                    MessageBox.Show($"reminder date must greater than now");
                    return;
                }

                if (endDate.Value < DateTime.Now)
                {
                    MessageBox.Show($"end date must greater than now");
                    return;
                }

                int numAvliableDay = endDate.Value.Day - DateTime.Now.Day;

                if (remindBeforeEnd.Value > 0 && remindBeforeEnd.Value < numAvliableDay && remindBeforeEnd.Value < 200)
                {
                    MessageBox.Show($"not avilable number of days and less than 200 day");
                    return;
                }

                if (titleValidation.Visible) return;


                var category = _context.Categories
               .Include(c => c.notes)
               .FirstOrDefault(c => c.CategoryId == _category.CategoryId);



                category.notes.Add(new Note
                {
                    Title = title.Text,
                    priority = (byte)priority.Value,
                    RemiderDate = reminderDate.Value,
                    LastDate = endDate.Value,
                    RemiderBeforeDays = (byte)remindBeforeEnd.Value,
                    Content = content.Text,
                    userId = CurrentUser.UserId
                });


                _context.SaveChanges();

                title.Clear();
                priority.Value = 0;
                reminderDate.Value = DateTime.Now;
                endDate.Value = DateTime.Now;
                remindBeforeEnd.Value = 0;
                content.Text = string.Empty;
                succeed.Text = "added succeed";
                succeed.Visible = true;
            }

            else
            {

               

                priority.Value = (byte)_note.priority;
                if (priority.Value < 0 || priority.Value > 5)
                {
                    MessageBox.Show($"priority must betwwen 0 and 5 ");
                    return;
                }

            
                if (reminderDate.Value < DateTime.Now)
                {
                    MessageBox.Show($"reminder date must greater than now");
                    return;
                }

               
                if (endDate.Value < DateTime.Now)
                {
                    MessageBox.Show($"end date must greater than now");
                    return;
                }

                int numAvliableDay = endDate.Value.Day - DateTime.Now.Day;
               
                if (remindBeforeEnd.Value > 0 && remindBeforeEnd.Value < numAvliableDay && remindBeforeEnd.Value < 200)
                {
                    MessageBox.Show($"not avilable number of days and less than 200 day");
                    return;
                }

                content.Text = _note.Content;

                if (titleValidation.Visible) return;



                _note.Title = title.Text;
                _note.priority = (byte)priority.Value;
                _note.RemiderDate = reminderDate.Value;
                _note.LastDate = endDate.Value;
                _note.RemiderBeforeDays = (byte)remindBeforeEnd.Value;
                _note.Content = content.Text;


                _context.Attach(_note);
                _context.Entry(_note).State = EntityState.Modified;
                _context.SaveChanges();


                //_context.Notes.Update(_note);
                //_context.SaveChanges();


                title.Clear();
                priority.Value = 0;
                reminderDate.Value = DateTime.Now;
                endDate.Value = DateTime.Now;
                remindBeforeEnd.Value = 0;
                content.Text = string.Empty;

                succeed.Text = "updated succeed";
                succeed.Visible = true;
            }

        }


        //clothing 
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
