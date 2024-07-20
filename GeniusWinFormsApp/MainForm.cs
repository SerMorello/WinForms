namespace GeniusWinFormsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            QuestionsStorage questions = new();
            Diagnoses diagnoses = new();

            UsersStorage users = new();
            users.GetUsers();
            User user = new();

            List<int> numbersQuestions = new();

            bool endGame = false;
        }
    }
}
