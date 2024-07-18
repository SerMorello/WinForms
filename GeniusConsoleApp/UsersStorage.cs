using Newtonsoft.Json;
using System.Collections;

public class UsersStorage : IEnumerable<User>
{
    public List<User> Users { get; set; } = new List<User>(1);
    private string path = "Users.json";

    public void GetUsers()
    {
        if (FileWork.CheckFile(path))
        {
            Users = Deserialize(FileWork.Read(path));
        }
    }
    public void AddUser(User user)
    {
        Users.Add(new User(user.Name, user.CountRightAnswers, user.Diagnose));

        FileWork.Write(Serialize(Users), path);
    }
    static string Serialize(List<User> users)
    {
        return JsonConvert.SerializeObject(users, Formatting.Indented);
    }
    static List<User> Deserialize(string value)
    {
        return JsonConvert.DeserializeObject<List<User>>(value);
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
