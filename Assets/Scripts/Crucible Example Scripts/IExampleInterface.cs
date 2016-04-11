//No imports from Unity Engine

//Name starts with I followed by another capital letter
public interface IExampleInterface<T>
{
    void SomeMethod(T value, float time);

    T SomeValue { get; set; }
}