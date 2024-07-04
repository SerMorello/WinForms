using Newtonsoft.Json;
using System.Collections;

public class UsersStorage : IEnumerable<User>
{
    public List<User> Users { get; set; } = new List<User>();
    private string path = "Users.json";

    public List<User> GetUsers()
    {
        FileWork.CheckFile(path);

        string value = FileWork.Deserialize(path);

        return JsonConvert.DeserializeObject<List<User>>(value);
    }
    public void AddUser(User user)
    {
        Users.Add(user);
    }
    public void SaveUsers()
    {
        FileWork.Serialize<List<User>>(Users, path);
    }
    IEnumerator<User> IEnumerable<User>.GetEnumerator()
    {
        return new UsersStorageEnumerator(Users);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return new UsersStorageEnumerator(Users);
    }
}
