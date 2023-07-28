namespace InheritanceC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Thanks for the birthday wishes", "Jhonnier Hernandez", true);

            Console.WriteLine(post1.ToString());

            ImagePost imagePost1 = new ImagePost("Check out my new shoes", "Jhonnier Hernandez", true, "https://images.com/shoes");

            Console.WriteLine(imagePost1.ToString());
        }
    }
}