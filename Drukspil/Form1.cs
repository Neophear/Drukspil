using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drukspil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public enum Category
        {
            Sex,
            Love,
            Law,
            Awkward
        }

        public static List<Question> questions = new Question[]
        {
            new Question("Jeg har aldrig prøvet analsex", Category.Sex),
            new Question("Jeg har aldrig givet oralsex", Category.Sex),
            new Question("Jeg har aldrig haft et one-night-stand", Category.Sex),
            new Question("Jeg har aldrig faket en orgasme", Category.Sex),
            new Question("Jeg har aldrig løjet mig til sex", Category.Sex),
            new Question("Jeg har aldrig haft sex mens mine forældre var hjemme", Category.Sex),
            new Question("Jeg har aldrig kysset en af det samme køn", Category.Sex),
            new Question("Jeg er aldrig blevet opdaget under sex", Category.Sex),
            new Question("Jeg er aldrig gået kold", Category.Awkward),
            new Question("Jeg har aldrig kørt spritkørsel", Category.Law),
            new Question("Jeg har aldrig kørt spritkørsel", Category.Law),
            new Question("Jeg har aldrig kørt overfor rødt", Category.Law),
            new Question("Jeg har aldrig spillet strippoker", Category.Sex),
            new Question("Jeg har aldrig slået op over sms", Category.Love),
            new Question("Jeg har aldrig slået op over sms", Category.Love),
            new Question("Jeg er aldrig blevet arresteret", Category.Law)
        }.ToList();

        private void btnNewQuestion_Click(object sender, EventArgs e)
        {
            GetQuestion();
        }

        private void GetQuestion()
        {
            Random rnd = new Random();
            int minimum = (int)questions.Min(question => question.TimesShown);
            List<Question> newQuestions = questions.Where(question => question.TimesShown == minimum).ToList();
            
            int indexToGet = rnd.Next(0, newQuestions.Count - 1);
            Question questionToAsk = newQuestions[indexToGet];
            questionToAsk.TimesShown++;

            lblQuestion.Text = questionToAsk.QuestionString + questionToAsk.TimesShown.ToString();
        }
    }
}
