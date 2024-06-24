using Newtonsoft.Json;

public class UsersStorage
{
    public List<User> Users { get; set; } = new List<User>();
    private string path = "Users.json";
    public List<User> GetUsers()
    {
        FileWork.CheckFile(path);

        string value = FileWork.Deserialize(path);

        return JsonConvert.DeserializeObject<List<User>>(value);


    }
    public void ShowUsersResult()
    {
        foreach (var user in Users)
        {
            Console.WriteLine($"Пользователь {user.Name} - правильных ответов {user.ShowUserScore}");
        }
    }
    public void AddUser(User user)
    {
        Users.Add(user);
    }
    public void SaveUsers()
    {
        FileWork.Serialize<List<User>>(Users, path);
    }
}