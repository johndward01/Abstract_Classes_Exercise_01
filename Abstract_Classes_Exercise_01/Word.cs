namespace Abstract_Classes_Exercise_01;

public class Word : Document
{
    public override void Load()
    {
        Console.WriteLine("Loading word document");
    }

    public override void Print()
    {
        Console.WriteLine("Printing word document");
    }

    public override void Save()
    {
        Console.WriteLine("Saving word document");
    }
}
