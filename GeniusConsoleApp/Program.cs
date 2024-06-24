User user = new();

Console.WriteLine("Введите ваше имя");
user.Name = Console.ReadLine();

QuestionsStorage questions = new();

Diagnoses diagnoses = new();

UsersStorage usersResult = new();
usersResult.GetUsers();

List<int> numbersQuestions = new();

bool endGame = false;

while (endGame == false)
{
    user.NewGameScore();
    numbersQuestions = questions.GetNumbersQuestions();

    for (int i = 0; i < questions.Questions.Count; i++)
    {
        Console.WriteLine("Вопрос №" + (i + 1));
        int questionIndex = questions.GetRandomNumberQuestion(numbersQuestions.Count, numbersQuestions);
        Console.WriteLine(questions.Questions[questionIndex].QuestionText);

        int userAnswer = Convert.ToInt32(Console.ReadLine());

        int rightAnswer = questions.Questions[questionIndex].Answer;

        if (userAnswer == rightAnswer)
        {
            user.IncreaseUserScore();
        }
    }

    int userScore = user.GetUserScore();
    //string userDiagnosis = diagnoses.GetDiagnoses(questions.CountQuestions, user.GetUserScore());

    user.Diagnose = diagnoses.GetDiagnoses(questions.CountQuestions, user.GetUserScore());

    Console.WriteLine($"{user.Name} Количество правильных ответов: {userScore}");
    Console.WriteLine($"Ваш диагноз: {user.Diagnose}");

    usersResult.AddUser(user);
    usersResult.SaveUsers();

    Console.WriteLine("Еще одну игру? 1 - Да, 2 - Нет");
    int replayGame = Convert.ToInt32(Console.ReadLine());

    if (replayGame == 2)
    {
       endGame = true;
    }
}
