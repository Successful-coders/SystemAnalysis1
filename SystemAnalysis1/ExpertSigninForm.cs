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
    public partial class ExpertSigninForm : Form
    {
        public ExpertSigninForm()
        {
            InitializeComponent();
        }

        private void ExpertSigninForm_Load(object sender, EventArgs e)
        {
            Test test = new Test();
            test.Show();

            Close();
        }
    }
}
