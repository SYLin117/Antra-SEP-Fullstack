namespace Assignment4;

public interface IRepository<T>
{
    void Add(T item);
    void Remove(T item);
}