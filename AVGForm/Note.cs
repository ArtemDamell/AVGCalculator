namespace AVGForm
{
    class Note
    {
        private int _sum = 0;
        private int _qty = 0;

        /// <summary>
        /// Delegate for showing notes.
        /// </summary>
        private DelegateShowNotes _showNotes;

        public Note(DelegateShowNotes show_notes)
        {
            _showNotes = show_notes;
            Clear();
        }

        /// <summary>
        /// Adds a note to the current sum and quantity of notes, and displays the average and quantity of notes.
        /// </summary>
        /// <param name="note">The note to be added.</param>
        public void AddNote(int note)
        {
            if (note < 1 || note > 5)
                return;
            _sum += note;
            _qty++;
            _showNotes(getAvg(), getQty());
        }

        /// <summary>
        /// Resets the sum and quantity to 0 and displays the average and quantity.
        /// </summary>
        public void Clear()
        {
            _sum = 0;
            _qty = 0;

            _showNotes(getAvg(), getQty());
        }

        /// <summary>
        /// Calculates the average of the values stored in the object.
        /// </summary>
        /// <returns>
        /// A string representation of the average value.
        /// </returns>
        public string getAvg()
        {
            float avg;

            if (_qty == 0)
                avg = 0.0f;
            else
                avg = _sum / ((float)_qty);

            return avg.ToString("0.0");
        }

        /// <summary>
        /// This method returns the quantity of the item as a string.
        /// </summary>
        public string getQty() => _qty.ToString();
    }
}
