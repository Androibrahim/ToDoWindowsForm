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
    public partial class NotesInCategoryForm : Form
    {
        private readonly AppDbContext _context;
        private Category? _category;
        public NotesInCategoryForm(Category category)
        {
            InitializeComponent();
            _context = new AppDbContext();
            _category = category;
            UserNameLabel.Text = CurrentUser.userName;
            CategoryName.Text = _category.Name.ToString();
            LoadDate();
        }

        private void LoadDate()
        {
            NotesInCategoryDataGrid.Rows.Clear();

            var category = _context.Categories.Include(n => n.notes).SingleOrDefault(c => c.CategoryId == _category.CategoryId);

            if (category.notes != null)
            {
                var notes = category.notes.Where(u => u.userId == CurrentUser.UserId && u.IsCompleted == false && u.isDeleted == false).Select(e => new { id = e.NoteId, title = e.Title, priority = e.priority, createAt = e.CreatedAt, reminderDate = e.RemiderDate }).ToList();
                foreach (var note in notes)
                {
                    NotesInCategoryDataGrid.Rows.Add(note.id, note.title, note.priority, note.createAt, note.reminderDate);
                }
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            MainHomeForm mainHomeForm = new MainHomeForm();
            mainHomeForm.Show();

            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            categoryForm.Show();

            this.Close();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            ToDoForm toDoForm = new ToDoForm();
            toDoForm.Show();

            this.Close();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();

            this.Close();
        }

        // add new note in category
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AddOrEditNote addOrEditNote = new AddOrEditNote(_category);
            addOrEditNote.ShowDialog();

            LoadDate();
        }

        private void NotesInCategoryDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (NotesInCategoryDataGrid.Columns[e.ColumnIndex].Name == "delete")
            {
                int id = Convert.ToInt32(NotesInCategoryDataGrid.Rows[e.RowIndex].Cells["noteId"].Value);

                Note? note = _context.Notes.SingleOrDefault(c => c.NoteId == id);

                if (note == null) return;

                _context.Notes.Remove(note);
                _context.SaveChanges();
                LoadDate();
            }


            if (NotesInCategoryDataGrid.Columns[e.ColumnIndex].Name == "edit")
            {
                int id = Convert.ToInt32(NotesInCategoryDataGrid.Rows[e.RowIndex].Cells["noteId"].Value);

                Note? note = _context.Notes.SingleOrDefault(c => c.NoteId == id);

                if (note == null) return;
                AddOrEditNote addOrEditNote = new AddOrEditNote( _category,note);
                addOrEditNote.ShowDialog();

                LoadDate();
            }


            if (NotesInCategoryDataGrid.Columns[e.ColumnIndex].Name == "show")
            {
                int id = Convert.ToInt32(NotesInCategoryDataGrid.Rows[e.RowIndex].Cells["noteId"].Value);

                Note? note = _context.Notes.SingleOrDefault(c => c.NoteId == id);

                if (note == null) return;
                NoteDetailsForm noteDetailsForm = new NoteDetailsForm(note);
                noteDetailsForm.ShowDialog();

                LoadDate();
            }
        }
    }
}
