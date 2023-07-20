namespace Abstract_Classes_Exercise_01;

public abstract class Document
{
    public string Title { get; set; }
    public string Author { get; set; }

    public abstract void Print();
    public abstract void Save();
    public abstract void Load();

}
