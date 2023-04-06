using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AVGForm
{
    public delegate void delegate_show_notes(string avg, string qty);
    public partial class AVGForm : Form
    {
        Note note;
        public AVGForm()
        {
            InitializeComponent();
            note = new Note(Show_notes);
            note.Clear();
        }

        private void Show_notes(string avg, string qty)
        {
            label_avg.Text = avg;
            label_qty.Text = qty;
        } 

        private void button_5_Click(object sender, EventArgs e)
        {
            note.AddNote(5);
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            note.AddNote(4);
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            note.AddNote(3);
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            note.AddNote(2);
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            note.Clear();
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            note.AddNote(1);
        }
    }
}
