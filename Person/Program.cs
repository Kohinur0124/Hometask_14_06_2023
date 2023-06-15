
namespace Person
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person Anvar = new Person("Anvar");
            Person Guli = new Person("Guli");

            Person.GetMarried(Anvar, Guli);
            Console.WriteLine($"Anvarning turmush o`rtog`i {Anvar.Spouse.Name}");
            Console.WriteLine($"Gulining turmush o`rtog`i {Guli.Spouse.Name}");
            Person Lola = new Person("Lola");
            Anvar.GetMarried(Lola);

        }
    }
}