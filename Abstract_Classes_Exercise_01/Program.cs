using Abstract_Classes_Exercise_01;
// TODO: Create an abstract class called Document 
// TODO: Inside of the Document class, create a property called Title
// TODO: Inside of the Document class, create a property called Author
// TODO: Inside of the Document class, create an abstract method called Print()
// TODO: Inside of the Document class, create an abstract method called Save()
// TODO: Inside of the Document class, create an abstract method called Load()


// TODO: Create 3 classes that inherit from the Document class: Word, PDF, and TextFile
//       and implement the methods



// TODO: Create 1 instance of each class, and call the 3 methods foreach creatively

var textfile = new TextFile();
Console.WriteLine(nameof(textfile).ToUpper());
textfile.Load();
textfile.Save();
textfile.Print();

Console.WriteLine();

var pdf = new PDF();
Console.WriteLine(nameof(pdf).ToUpper());
pdf.Load();
pdf.Save();
pdf.Print();

Console.WriteLine();

var wordDocument = new Word();
Console.WriteLine(nameof(wordDocument).ToUpper());
wordDocument.Load();
wordDocument.Save();
wordDocument.Print();
