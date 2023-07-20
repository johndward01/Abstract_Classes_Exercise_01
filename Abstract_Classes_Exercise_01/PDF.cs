namespace Abstract_Classes_Exercise_01;

public class PDF : Document
{
    public override void Load()
    {
        Console.WriteLine("Loading PDF document");
    }

    public override void Print()
    {
        Console.WriteLine("Printing PDF document");
    }

    public override void Save()
    {
        Console.WriteLine("Saving PDF document");
    }
}
