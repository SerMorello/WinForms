public class UsersResultStorage
{
    public List<User> Users { get; set; } = new List<User>();
    private string path = "User.txt";
    public void GetUsersScore ()
    {
        Users = FileWork.Deserialize<List<User>>(path);

        foreach (var user in Users)
        {
            Console.WriteLine($"Пользователь {user.Name} - правильных ответов {user.ShowUserScore}");
        }
    }
    public void AddUser(User user)
    {
        Users.Add(user);
    }
    public void SaveUsers ()
    {
        FileWork.Serialize<List<User>>(Users, path);
    }
}