﻿using System;
using System.Windows.Forms;

namespace AVGForm
{
    public delegate void DelegateShowNotes(string avg, string qty);
    public partial class AVGForm : Form
    {
        private Note _note;
        public AVGForm()
        {
            InitializeComponent();
            _note = new Note(Show_notes);
            _note.Clear();
        }

        /// <summary>
        /// This method displays the average and quantity of a given item.
        /// </summary>
        /// <param name="avg">The average of the item.</param>
        /// <param name="qty">The quantity of the item.</param>
        private void Show_notes(string avg, string qty)
        {
            label_avg.Text = avg;
            label_qty.Text = qty;
        }

        /// <summary>
        /// This method adds a note with value to the _note object.
        /// </summary>
        private void button_5_Click(object sender, EventArgs e) => _note.AddNote(5);
        private void button_4_Click(object sender, EventArgs e) => _note.AddNote(4);
        private void button_3_Click(object sender, EventArgs e) => _note.AddNote(3);
        private void button_2_Click(object sender, EventArgs e) => _note.AddNote(2);
        private void button_1_Click(object sender, EventArgs e) => _note.AddNote(1);
        private void button_reset_Click(object sender, EventArgs e) => _note.Clear();
    }
}
