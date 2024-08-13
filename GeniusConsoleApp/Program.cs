QuestionsStorage questions = new();

Diagnoses diagnoses = new();

UsersStorage users = new();
users.GetUsers();

User user = new();

Console.WriteLine("Введите ваше имя");
user.Name = Console.ReadLine();

List<int> numbersQuestions = new();

bool endGame = false;

while (!endGame)
{
    switch (ShowMenu())
    {
        case 1:
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

            user.Diagnose = diagnoses.GetDiagnoses(questions.CountQuestions, user.GetUserScore());

            Console.WriteLine();
            Console.WriteLine($"{user.Name} Количество правильных ответов: {userScore}");
            Console.WriteLine($"Ваш диагноз: {user.Diagnose}");
            Console.WriteLine();

            users.AddUser(user);

            break;

        case 2:
            Console.WriteLine();
            foreach (var userResult in users)
            {
                Console.WriteLine($"Пользователь {userResult.Name}, с диагнозом {userResult.Diagnose} - правильных ответов {userResult.CountRightAnswers}");
            }
            Console.WriteLine();

            break;

        case 3:
            Console.WriteLine();
            questions.GetQuestions();
            for (int i = 0; i < questions.Questions.Count; i++)
            {
                Console.WriteLine($"{i + 1} {questions.Questions[i].QuestionText}");
            }
            Console.WriteLine();

            break;

        case 4:
            var addQuestion = new Question();

            Console.WriteLine();
            Console.WriteLine("Введите текст вопроса");
            addQuestion.QuestionText = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Введите текст ответа");
            addQuestion.Answer = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            questions.AddQuestion(addQuestion);
            Console.WriteLine("Вопрос добавлен");
            break;

        case 5:
            Console.WriteLine("Выберите номер вопроса который хотите удалить");

            questions.GetQuestions();
            for (int i = 0; i < questions.Questions.Count; i++)
            {
                Console.WriteLine($"{i + 1} {questions.Questions[i].QuestionText}");
            }

            int numberRemoveQuestion = Convert.ToInt32(Console.ReadLine());
            questions.RemoveQuestion(numberRemoveQuestion - 1);
            Console.WriteLine("Вопрос удален");
            break;

        case 6: endGame = true; break;
    }
}
int ShowMenu()
{
    Console.WriteLine("1.Новая игра\r\n2.Показать результаты\r\n3.Показать вопросы \r\n4.Добавить вопрос\r\n5.Удалить вопрос\r\n6.Закончить игрру");
    return Convert.ToInt32(Console.ReadLine());
}