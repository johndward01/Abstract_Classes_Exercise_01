namespace Abstract_Classes_Exercise_01;

public class TextFile : Document
{
    public override void Load()
    {
        Console.WriteLine("Loading text document");
    }

    public override void Print()
    {
        Console.WriteLine("Printing text document");
    }

    public override void Save()
    {
        Console.WriteLine("Saving text document");
    }
}
