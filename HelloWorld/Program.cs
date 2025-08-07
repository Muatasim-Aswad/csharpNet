// See https://aka.ms/new-console-template for more information
using HelloWorld;

// Console.WriteLine("Hello, World!");

//HelloWorld.StringExamples.RunExamples();
//MadLibs.Run();
// ArraysH.Run();

Star sun = new Star("Sun", "G-type");

sun.Shine();
sun.GrowOlder();
sun.Shine();
sun.GrowOlder();
sun.Supernova();

Star newStar = new Star("Sirius");

newStar.Shine();
newStar.GrowOlder();
newStar.GrowOlder();

sun.Comments = "\nThis is the Sun, our solar system's star.";
Console.WriteLine($"\n{sun.Comments}");

sun.ExtraInfo = "\nIt is the brightest object in the sky during the day.";
Console.WriteLine($"\n{sun.ExtraInfo}");

