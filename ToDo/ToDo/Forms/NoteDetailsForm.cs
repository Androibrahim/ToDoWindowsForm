using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDo.Model;

namespace ToDo.Forms
{
    public partial class NoteDetailsForm : Form
    {
        private Note _note;
        public NoteDetailsForm(Note note)
        {
            InitializeComponent();
            _note = note;


            titleNote.Text = note.Title;
            LastDate.Text = note.LastDate.ToString();
            remindBefore.Text = note.RemiderBeforeDays.ToString();
            content.Text = note.Content;
        }

        // Close
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
