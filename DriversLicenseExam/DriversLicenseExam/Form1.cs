namespace DriversLicenseExam
{
    public partial class Form1 : Form
    {
        private string[] correctAnswers = { "B", "D", "A", "A", "C", "A", "B", "A", "C", "D", "B", "C", "D", "A", "D", "C", "C", "B", "D", "A" };
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = textBox2.Text;

            if (File.Exists(filePath))
            {
                string[] studentAnswers = File.ReadAllLines(filePath);
                int correctQuestionsNumber = GradeExam(studentAnswers);
                bool hasPassed = correctQuestionsNumber >= 15;

                string examScoreResult;
                if (hasPassed)
                {
                    examScoreResult = "You've passed!";
                }
                else
                {
                    examScoreResult = "You've failed!";
                }

                string scoreMessage = "Total Correct: " + correctQuestionsNumber.ToString();
                string totalIncorrects = "Total Incorrect: " + (20 - correctQuestionsNumber).ToString();

                textBox1.Text = scoreMessage + " ," + totalIncorrects + " ," + examScoreResult;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {



        }

        private int GradeExam(string[] studentAnswers)
        {
            int scoreCounter = 0;
            int questionNumber = 0;

            foreach (string studentAnswer in studentAnswers)
            {
                if (studentAnswer == correctAnswers[questionNumber])
                    scoreCounter++;

                questionNumber++;
            }

            return scoreCounter;
        }
    }
}