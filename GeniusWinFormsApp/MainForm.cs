namespace GeniusWinFormsApp
{
    public partial class mainForm : Form
    {
        int numberQestion = 1;
        QuestionsStorage questions = new();
        List<int> numbersQuestions = new();
        Diagnoses diagnoses = new();
        //UsersStorage users = new();
        User user = new();

        public mainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            numbersQuestions = questions.GetNumbersQuestions();


            int questionIndex = questions.GetRandomNumberQuestion(numbersQuestions.Count, numbersQuestions);

            //users.GetUsers();

            newUserForm newUserForm = new();
            newUserForm.ShowDialog();
            user.Name = newUserForm.newUser;

            QuestionNumberLabel.Text = $"Вопрос {numberQestion}";
            QuestionTextLabel.Text = questions.Questions[questionIndex].QuestionText;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (numbersQuestions.Count == 0)
            {
                int userScore = user.GetUserScore();
                user.Diagnose = diagnoses.GetDiagnoses(questions.CountQuestions, user.GetUserScore());

                MessageBox.Show($"{user.Name} ты просто {user.Diagnose}");
                return;
            }

            numberQestion++;
            QuestionNumberLabel.Text = $"Вопрос {numberQestion}";

            int questionIndex = questions.GetRandomNumberQuestion(numbersQuestions.Count, numbersQuestions);
            QuestionTextLabel.Text = questions.Questions[questionIndex].QuestionText;

            int userAnswer = Convert.ToInt32(userAnswerTextBox.Text);

            int rightAnswer = questions.Questions[questionIndex].Answer;

            if (userAnswer == rightAnswer)
            {
                user.IncreaseUserScore();
            }

            userAnswerTextBox.Text = "";
        }
    }
}
