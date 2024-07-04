using System.Collections;

public class QuestionStorageEnumerator : IEnumerator<Question>
{
    private readonly List<Question> questions;
    public int CurrentIndex = -1;
    public QuestionStorageEnumerator(List<Question> questions)
    {
        this.questions = questions;
    }

    public Question Current => questions[CurrentIndex];

    object IEnumerator.Current => questions[CurrentIndex];



    public bool MoveNext()
    {
        CurrentIndex++;
        if (CurrentIndex>=questions.Count)
        {
            return false;
        }
        return true;
    }

    public void Reset()
    {
        CurrentIndex = -1;
    }
    public void Dispose()
    { }
}
