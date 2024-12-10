using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_projekt2
{
    public partial class Form1 : Form
    {
        public class QuizQuestion
        {
            public string QuestionText { get; set; }
            public string AnswerOption1 { get; set; }
            public string AnswerOption2 { get; set; }
            public string AnswerOption3 { get; set; }
            public string AnswerOption4 { get; set; }
            public string CorrectAnswerKey { get; set; }
            public string CorrectAnswerExplanation { get; set; }

            public QuizQuestion(
                string questionText,
                string answerOption1,
                string answerOption2,
                string answerOption3,
                string answerOption4,
                string correctAnswerKey,
                string correctAnswerExplanation)
            {
                QuestionText = questionText?.Trim();
                AnswerOption1 = answerOption1?.Trim();
                AnswerOption2 = answerOption2?.Trim();
                AnswerOption3 = answerOption3?.Trim();
                AnswerOption4 = answerOption4?.Trim();
                CorrectAnswerKey = correctAnswerKey?.Trim();
                CorrectAnswerExplanation = correctAnswerExplanation?.Trim();
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        
    }
}
