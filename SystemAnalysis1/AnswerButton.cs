using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemAnalysis1
{
    public class AnswerButton : Button
    {
        private int[] indexes;


        public delegate void OnClickedHandler(int[] indexes);
        public event OnClickedHandler OnAnswerClick;


        public AnswerButton(int[] indexes) : base()
        {
            this.indexes = indexes;
            Click += OnClicked;
        }


        private void OnClicked(object sender, EventArgs e)
        {
            OnAnswerClick?.Invoke(indexes);
        }
    }
}
