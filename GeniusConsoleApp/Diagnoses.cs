public class Diagnoses
{
    public List<string> userDiagnoses { get; } = new List<string>();
    public Diagnoses()
    {
        userDiagnoses.Insert(0, "кретин");
        userDiagnoses.Insert(1, "идиот");
        userDiagnoses.Insert(2, "дурак");
        userDiagnoses.Insert(3, "нормальный");
        userDiagnoses.Insert(4, "талант");
        userDiagnoses.Insert(5, "гений");


        //userDiagnoses.Add("кретин");
        //userDiagnoses.Add("идиот");
        //userDiagnoses.Add("дурак");
        //userDiagnoses.Add("нормальный");
        //userDiagnoses.Add("талант");
        //userDiagnoses.Add("гений");
    }
    public string GetDiagnoses(int countQuestion, int countRightAnswers)
    {
        int percentageCorrectAnswers = countQuestion / countRightAnswers * 75;
        return userDiagnoses[userDiagnoses.Count / percentageCorrectAnswers];
    }
}