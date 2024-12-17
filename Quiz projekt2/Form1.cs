using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

        private List<QuizQuestion> questions = new List<QuizQuestion>();
        private string correctAnswerKey;
        private string correctAnswerExplanation;
        private int score = 0;
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            LoadQuestions();
            ShowRandomQuestion();
            InitializeQuiz();
            valasz.Click += valasz_Click;
        }

        private void InitializeQuiz()
        {
            scoreLabel.Text = "Score: " + score.ToString();
        }

        private void LoadQuestions()
        {
            string filePath = @"E:\visual projektek\Quiz projekt2\Quiz projekt2\bin\Debug\kerdesek.txt";

            if (!File.Exists(filePath))
            {
                MessageBox.Show("Nem található a fájl: " + filePath);
                return;
            }

            questions.Clear();

            try
            {
                StreamReader reader = new StreamReader(filePath);

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    string[] lineParts = line.Split('/').Select(p => p.Trim()).ToArray();

                    if (lineParts.Length != 7)
                    {
                        MessageBox.Show("Helytelen válasz formátum!");
                        return;
                    }

                    QuizQuestion question = new QuizQuestion(
                        questionText: lineParts[0],
                        answerOption1: lineParts[1],
                        answerOption2: lineParts[2],
                        answerOption3: lineParts[3],
                        answerOption4: lineParts[4],
                        correctAnswerKey: lineParts[5],
                        correctAnswerExplanation: lineParts[6]
                    );

                    questions.Add(question);
                }

                reader.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show("Nem tudja beolvasni a szöveget: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Váratlan hiba: " + ex.Message);
            }
        }

        private void ShowRandomQuestion()
        {
            if (questions.Count == 0)
            {
                MessageBox.Show("Nincs több kérdés!");
                return;
            }

            int randomIndex = random.Next(questions.Count);
            QuizQuestion selectedQuestion = questions[randomIndex];

            questionbar.Text = selectedQuestion.QuestionText;
            option1.Text = selectedQuestion.AnswerOption1;
            option2.Text = selectedQuestion.AnswerOption2;
            option3.Text = selectedQuestion.AnswerOption3;
            option4.Text = selectedQuestion.AnswerOption4;

            correctAnswerKey = selectedQuestion.CorrectAnswerKey;
            correctAnswerExplanation = selectedQuestion.CorrectAnswerExplanation;

            answerTextBox.Clear();
        }

        private void CheckAnswer()
        {
            if (string.IsNullOrWhiteSpace(answerTextBox.Text))
            {
                MessageBox.Show("Kérlek válaszolj!");
                return;
            }

            string userAnswer = answerTextBox.Text.Trim().ToUpper();
            if (userAnswer != "A" && userAnswer != "B" && userAnswer != "C" && userAnswer != "D")
            {
                MessageBox.Show("Nem megfelelő válasz! Kérlek válassz a következők közül: A, B, C, vagy D.");
                return;
            }

            string correctAnswer = correctAnswerKey.Trim().ToUpper();

            if (userAnswer == correctAnswer)
            {
                MessageBox.Show("Helyes!");
                score++;
            }
            else
            {
                MessageBox.Show($"Rossz! Helyes válasz: {correctAnswerKey}\nMagyarázat: {correctAnswerExplanation}");
            }

            scoreLabel.Text = "Score: " + score.ToString();
            ShowRandomQuestion();
        }

        private void valasz_Click(object sender, EventArgs e)
        {
            CheckAnswer();
        }

        
    }
}
