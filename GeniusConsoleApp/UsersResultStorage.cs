public class UsersResultStorage
{
    public List<User> Users { get; set; } = new List<User>();
    public void GetUsersScore ()
    {
        foreach (var user in Users)
        {
            Console.WriteLine($"Пользователь {user.Name} - правильных ответов {user.ShowUserScore}");
        }
    }
}