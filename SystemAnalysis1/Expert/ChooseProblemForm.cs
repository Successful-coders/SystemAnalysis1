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
    public partial class ChooseProblemForm : Form
    {
        private List<Problem> problems;

        public ChooseProblemForm(string expertName)
        {
            InitializeComponent();

            nameLabel.Text = "Эксперт: " + expertName;

            InitProblems(expertName);
        }


        private void InitProblems(string expertName)
        {
            problemsList.Items.Clear();

            problems = Data.problems.Where(x => x.experts.Any(y => y.name == expertName)).ToList();

            for (int i = 0; i < problems.Count; i++)
            {
                problemsList.Items.Add(new ListViewItem(new string[] { (i + 1).ToString(), problems[i].name }));
            }
        }

        private void problemsList_DoubleClick(object sender, EventArgs e)
        {
            Problem problem = problems.FirstOrDefault(x => x.name == problemsList.SelectedItems[0].SubItems[1].Text);

            Hide();
            ExpertTest expertTest = new ExpertTest(problem.alternatives);
            expertTest.Closed += (s, args) => Show();
            expertTest.Show();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
