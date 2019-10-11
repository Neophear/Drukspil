using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drukspil
{
    public class Question
    {
        private string _question;
        private Form1.Category _category;
        private int _timesShown = 0;

        public Question()
        {
            
        }
        public Question(string QuestionString, Form1.Category Category)
        {
            this._question = QuestionString;
            this._category = Category;
        }
        public string QuestionString
        {
            get { return _question; }
            set { _question = value; }
        }
        public Form1.Category Category
        {
            get { return _category; }
            set { _category = value; }
        }
        public int TimesShown
        {
            get { return _timesShown; }
            set { _timesShown = value; }
        }
    }
}