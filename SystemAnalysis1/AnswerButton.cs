using System;
using System.Collections.Generic;
using System.Drawing;
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

        private Color enabledColor = Color.Chocolate;
        private Color disabledColor = Color.Gray;

        public delegate void OnClickedHandler(int questionIndex, int[] indexes);
        public event OnClickedHandler OnAnswerClick;


        public AnswerButton(int questionIndex, int[] indexes) : base()
        {
            this.questionIndex = questionIndex;
            this.indexes = indexes;
            Click += OnClicked;
            EnabledChanged += OnEnabledChanged;
        }


        private void OnClicked(object sender, EventArgs e)
        {
            OnAnswerClick?.Invoke(questionIndex, indexes);
        }
        private void OnEnabledChanged(object sender, EventArgs e)
        {
            if (Enabled)
            {
                BackColor = enabledColor;
            }
            else
            {
                BackColor = disabledColor;
            }
        }
    }
}
