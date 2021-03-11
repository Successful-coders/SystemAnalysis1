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
    public partial class Test : Form
    {
        MethodCoupleCompare method = new MethodCoupleCompare();
        Alternatives alternatives = new Alternatives();
        int questionNumber = 1;
        int totalQuestion = 4;// брать из кол-ва альтернатив в квадрате
        public Test()
        {
            InitializeComponent();
            AskQuestion(questionNumber);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            ExpertForm expert = new ExpertForm();
            expert.Closed += (s, args) => Show();
            expert.Show();
            Hide();
        }

        private void CheckAnswer(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (questionNumber != totalQuestion)
            {
                //method.Z[]
                questionNumber++;
                AskQuestion(questionNumber);
            }
            if(questionNumber == totalQuestion)
            {
                MessageBox.Show("Спасибо за пройденный опрос!");
                ExpertForm expert = new ExpertForm();
                expert.Closed += (s, args) => Show();
                expert.Show();
                Hide();
            }

        }
        private void AskQuestion (int qnum)
        {
            
            switch (qnum)
            {
                case 1:
                    // вместо просто строки ссылка на альтернативу которую мы добавили в класс альтернатив из формы для аналитика
                    first.Text = "Открытие дополнительного филиала в городе";
                    second.Text = "Приобретение нового здания большего размера и расширение банка";

                break;
                case 2:
                    first.Text = "Открытие дополнительного филиала в городе";
                    second.Text = "Введение круглосуточного режима работы";
                    break;
                case 3:
                    first.Text = "Открытие дополнительного филиала в городе";
                    second.Text = "Cокращение численности кадров";
                break;
            }
        }

        private void second_Click(object sender, EventArgs e)
        {

        }
    }
}
