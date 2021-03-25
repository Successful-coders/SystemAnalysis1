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
        private int questionIndex;


        public delegate void OnClickedHandler(int questionIndex, int[] indexes);
        public event OnClickedHandler OnAnswerClick;


        public AnswerButton(int questionIndex, int[] indexes) : base()
        {
            this.questionIndex = questionIndex;
            this.indexes = indexes;
            Click += OnClicked;
        }


        private void OnClicked(object sender, EventArgs e)
        {
            OnAnswerClick?.Invoke(questionIndex, indexes);
        }
    }
}
