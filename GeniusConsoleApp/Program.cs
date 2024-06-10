Console.WriteLine("Введите ваше имя");
string user = Console.ReadLine();
int countQuestions = 5;
List<int> numberQuestions = new List<int>();
string[] questions = Questions.GetQuestions(countQuestions);
int[] answers = new int[countQuestions];
answers[0] = 6;
answers[1] = 9;
answers[2] = 25;
answers[3] = 60;
answers[4] = 2;

string[] diagnoses = new string[6];
diagnoses[0] = "кретин";
diagnoses[1] = "идиот";
diagnoses[2] = "дурак";
diagnoses[3] = "нормальный";
diagnoses[4] = "талант";
diagnoses[5] = "гений";

bool endGame = false;


int countRightAnswers = 0;

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
    numberQuestions = [0, 1, 2, 3, 4];
    countRightAnswers = 0;

    for (int i = 0; i < countQuestions; i++)
    {
        Console.WriteLine("Вопрос №" + (i + 1));
        int questionIndex = GetRandomNumberQuestion(numberQuestions.Count, numberQuestions);
        Console.WriteLine(questions[questionIndex]);

        int userAnswer = Convert.ToInt32(Console.ReadLine());

        int rightAnswer = answers[questionIndex];

        if (userAnswer == rightAnswer)
        {
            countRightAnswers++;
        }
    }


    Console.WriteLine($"{user} Количество правильных ответов: {countRightAnswers}");
    Console.WriteLine("Ваш диагноз:" + diagnoses[countRightAnswers]);

    Console.WriteLine("Еще одну игру? 1 - Да, 2 - Нет");
    int replayGame = Convert.ToInt32(Console.ReadLine());

    if (replayGame == 2)
    {
        endGame = true;
    }
}
