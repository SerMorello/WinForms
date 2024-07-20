public class User
{
    public string Name { get; set; } = "Непонятно";
    public int CountRightAnswers { get; set; } = 0;
    public string Diagnose { get; set; } = "Без диагноза";
    public User() { }
    public User(string name, int countRightAnswers, string diagnose)
    {
        Name = name;
        CountRightAnswers = countRightAnswers;
        Diagnose = diagnose;
    }

    public void IncreaseUserScore()
    {
        CountRightAnswers += 1;
    }
    public int GetUserScore() => CountRightAnswers;
    public void ShowUserScore() => Console.Write(CountRightAnswers);
    public void NewGameScore()
    {
        CountRightAnswers = 0;
    }
}
