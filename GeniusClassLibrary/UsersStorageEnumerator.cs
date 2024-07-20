using System.Collections;

public class UsersStorageEnumerator : IEnumerator<User>
{
    private readonly List<User> users;
    public int currentIndex = -1;

    public UsersStorageEnumerator(List<User> users)
    { this.users = users; }
    public User Current => users[currentIndex];

    object IEnumerator.Current => users[currentIndex];
    public bool MoveNext()
    {
        currentIndex++;
        if (currentIndex >= users.Count)
        {
            return false;
        }
        return true;
    }

    public void Reset()
    {
        currentIndex = -1;
    }
    public void Dispose()
    { }
}
