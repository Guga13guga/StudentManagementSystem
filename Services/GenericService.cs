

using StudentManagementSystem.InterFaceses;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;

namespace StudentManagementSystem.Services;

public class GenericService <T> : IGenericService <T> where T : class 
{
    protected List<T> list;
    private readonly string Url;

    public GenericService(string url)
    {
        this.list = new List<T>();
        Url = url;
        LoadFromFile();
    }

    public void Add(T item)
    {
        this.list.Add(item);
        SaveChangesToFile();
    }

    public void UpdateAt(int Index,T item )
    {
        list[Index] = item;
        SaveChangesToFile();
    }

    public T Get(int Index) 
    { 
        return this.list[Index];
    }

    public void Remove(int Index)
    {
        this.list.RemoveAt(Index);
        Console.WriteLine($"{Index} ------ Removed");
        SaveChangesToFile();
    }

    public List<T> GetAll()
    {
        return list;
    }

    public void LoadFromFile()
    {
        if (File.Exists(Url))
        {
            var FileContex = File.ReadAllText(Url);
            if (!string.IsNullOrEmpty(FileContex))
            {
                var DesContent = JsonSerializer.Deserialize<List<T>>(FileContex);
                if(DesContent != null)
                {
                    list = DesContent;
                }
            }
        }
    }

    public void SaveChangesToFile()
    {
        if (File.Exists(Url))
        {
            File.Delete(Url);
            File.Create(Url).Close();

          var JsonContent = JsonSerializer.Serialize(list);
            if (JsonContent != null)
            {
                File.WriteAllText(Url, JsonContent);
            }
        }
        else
        {
            File.Create(Url).Close();

            var JsonContent = JsonSerializer.Serialize(list);
            if (JsonContent != null)
            {
                File.WriteAllText(Url, JsonContent);
            }
        }

    }

}
