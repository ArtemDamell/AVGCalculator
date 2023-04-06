namespace AVGForm
{
    class Note
    {
        private int _sum = 0;
        private int _qty = 0;

        private DelegateShowNotes _show_notes;

        public Note(DelegateShowNotes show_notes)
        {
            _show_notes = show_notes;
            Clear();
        }

        public void AddNote(int note)
        {
            if (note < 1 || note > 5)
                return;
            _sum += note;
            _qty++;
            _show_notes(getAvg(), getQty());
        }

        public void Clear()
        {
            _sum = 0;
            _qty = 0;

            _show_notes(getAvg(), getQty());
        }

        public string getAvg()
        {
            float avg;

            if (_qty == 0)
                avg = 0.0f;
            else
                avg = _sum / ((float)_qty);

            return avg.ToString("0.0");
        }

        public string getQty()
        {
            return _qty.ToString();
        }
    }
}
