using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemAnalysis1
{
    public partial class EditAlternativeForm : Form
    {
        private Alternative alternative;


        public EditAlternativeForm(Alternative alternative)
        {
            InitializeComponent();

            this.alternative = alternative;
        }


        private void applyButton_Click(object sender, EventArgs e)
        {
            alternative.description = descriptionTextBox.Text;
            Close();
        }
    }
}
