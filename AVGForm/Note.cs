using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVGForm
{
    class Note
    {
        int sum = 0;
        int qty = 0;

        delegate_show_notes show_notes;

        public Note(delegate_show_notes show_notes)
        {
            this.show_notes = show_notes;
            Clear();
        }

        public void AddNote(int note)
        {
            if (note < 2 || note > 5)
                return;
            sum += note;
            qty++;
            show_notes(getAvg(), getQty());
        }

        public void Clear()
        {
            sum = 0;
            qty = 0;

            show_notes(getAvg(), getQty());
        }

        public string getAvg()
        {
            float avg;

            if (qty == 0)
                avg = 0.0f;
            else
                avg = ((float)sum) / ((float)qty);

            return avg.ToString("0.0");
        }

        public string getQty()
        {
            return qty.ToString();
        }
    }
}
