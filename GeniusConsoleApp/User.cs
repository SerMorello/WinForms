public class User
{
    public string Name { get; set; } = "Непонятно";
    private int CountRightAnswers { get; set; } = 0;
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
