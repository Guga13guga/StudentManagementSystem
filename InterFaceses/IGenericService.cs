namespace StudentManagementSystem.InterFaceses;

/// <summary>
/// Generic Service Interface for CRUD operations
/// </summary>
/// <typeparam name="T"></typeparam>
public interface IGenericService <T> where T : class
{
    void Add(T item);

    void UpdateAt(int Index, T item);
    /// <summary>
    /// Returns Item BY Id
    /// </summary>
    /// <param name="Index"></param>
    /// <returns></returns>
    T Get(int Index); 

    void Remove(int Index);

    List<T> GetAll();
}
