using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestList
{
    internal class ExtendedCheckedListBox : CheckedListBox
    {
        private bool descSorted = false;

        public new bool Sorted 
        { 
            get { return base.Sorted; } 
            set 
            { 
                if (value) DESCSorted = false;
                base.Sorted = value; 
            }
        }

        public bool DESCSorted
        {
            get { return descSorted; }
            set 
            {
                if (value && descSorted != value) 
                {
                    this.Sorted = false;
                    descSorted = value;
                    if (base.Items is not null && base.Items.Count > 1)
                    {
                        this.RevertedSort();
                    }
                    
                }
                else this.descSorted = value;


            }
        }

        protected void RevertedSort()
        {
            if (!(DESCSorted && this.Items is not null && this.Items.Count > 1)) return;

            this.BeginUpdate();

            this.TrueSort();
            
            object[] temp = new object[base.Items.Count];
            base.Items.CopyTo(temp, 0);
            base.Items.Clear();
            for (int i = 1; i <= temp.Length; i++) 
            {
                base.Items.Add(temp[^i]);
            }

            this.EndUpdate();
            

        }

        public int Add(object item) 
        {


            var res = this.Items.Add(item);
            if (!descSorted) return res;
            this.RevertedSort();

            return res;

        }

        private void TrueSort() 
        {
            bool tempSorted = base.Sorted;
            base.Sorted = true;
            base.Sorted = tempSorted;
        }


    }
}
