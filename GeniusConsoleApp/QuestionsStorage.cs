﻿using System.Collections;

public class QuestionsStorage : IEnumerable<Question>
{
    private string path = "Questions.json";
    public List<Question> Questions { get; set; } = new List<Question>();
    public int CountQuestions { get; }

    public QuestionsStorage()
    {
        Questions = GetQuestions();
        CountQuestions = Questions.Count;
    }
    public List<Question> GetQuestions()
    {
        FileWork.CheckFile(path);

        List<Question> questions = new();
        questions.Add(new Question("Сколько будет два плюс два умноженное на два?", 6));
        questions.Add(new Question("Бревно нужно распилить на 10 частей. Сколько распилов нужно сделать?", 9));
        questions.Add(new Question("На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25));
        questions.Add(new Question("Укол делают каждые полчаса. Сколько нужно минут, чтобы сделать три укола?", 60));
        questions.Add(new Question("Пять свечей горело, две потухли. Сколько свечей осталось?", 2));
        return questions;
    }
    public List<int> GetNumbersQuestions()
    {
        List<int> numbers = new();

        for (int i = 0; i < CountQuestions; i++)
        {
            numbers.Add(i);
        }

        return numbers;
    }
    public int GetRandomNumberQuestion(int countQuestions, List<int> numberQuestions)
    {
        Random random = new Random();

        int randomNumber = random.Next(0, countQuestions);
        int randomQuestionIndex = numberQuestions[randomNumber];
        numberQuestions.RemoveAt(randomNumber);

        return randomQuestionIndex;
    }
    public void AddQuestion(Question newQuestion)
    {
        List<Question> questions = GetQuestions();
        questions
    }
    public IEnumerator<Question> GetEnumerator()
    {
        return new QuestionStorageEnumerator(Questions);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return new QuestionStorageEnumerator(Questions);
    }
}
