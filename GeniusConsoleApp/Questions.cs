﻿




public class Questions
{
    public static string[] GetQuestions(int countQuestions)
    {
        string[] questions = new string[countQuestions];
        questions[0] = "Сколько будет два плюс два умноженное на два?";
        questions[1] = "Бревно нужно распилить на 10 частей. Сколько распилов нужно сделать?";
        questions[2] = "На двух руках 10 пальцев. Сколько пальцев на 5 руках?";
        questions[3] = "Укол делают каждые полчаса. Сколько нужно минут, чтобы сделать три укола?";
        questions[4] = "Пять свечей горело, две потухли. Сколько свечей осталось?";
        return questions;
    }
}