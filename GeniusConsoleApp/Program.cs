User user = new();

Console.WriteLine("Введите ваше имя");
user.Name = Console.ReadLine();

QuestionsStorage questions = new();

List<int> numbersQuestions = questions.GetNumbersQuestions();

string[] diagnoses = new string[6];
diagnoses[0] = "кретин";
diagnoses[1] = "идиот";
diagnoses[2] = "дурак";
diagnoses[3] = "нормальный";
diagnoses[4] = "талант";
diagnoses[5] = "гений";

bool endGame = false;

static int GetRandomNumberQuestion(int countQuestions, List<int> numberQuestions)
{
    Random random = new Random();

    int randomNumber = random.Next(0, countQuestions);
    int randomQuestionIndex = numberQuestions[randomNumber];
    numberQuestions.RemoveAt(randomNumber);

    return randomQuestionIndex;

}
while (endGame == false)
{

    user.NewGameScore();
    numbersQuestions = questions.GetNumbersQuestions();

    for (int i = 0; i < questions.Questions.Count; i++)
    {
        Console.WriteLine("Вопрос №" + (i + 1));
        int questionIndex = GetRandomNumberQuestion(numbersQuestions.Count, numbersQuestions);
        Console.WriteLine(questions.Questions[questionIndex].QuestionText);

        int userAnswer = Convert.ToInt32(Console.ReadLine());

        int rightAnswer = questions.Questions[questionIndex].Answer;

        if (userAnswer == rightAnswer)
        {
            user.IncreaseUserScore();
        }
    }


    Console.WriteLine($"{user.Name} Количество правильных ответов: {user.ShowUserScore}");
    Console.WriteLine("Ваш диагноз:" + diagnoses[user.GetUserScore()]);

    Console.WriteLine("Еще одну игру? 1 - Да, 2 - Нет");
    int replayGame = Convert.ToInt32(Console.ReadLine());

    if (replayGame == 2)
    {
        endGame = true;
    }
}
