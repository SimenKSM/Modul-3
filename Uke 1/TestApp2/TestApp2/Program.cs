namespace TestApp2
{
    internal class Program
    {
        int helTall = 1;
        float desimalTall = 1.01F; // Nøyaktig
        decimal desimalTall2 = 1.01M;
        double desimalTall3 = 1.01; // Veldig Nøyaktig

        char bokstav = 'a';
        string tekst = "Hei";

        bool santUsant = true; // eller false

        int[] tallArray = { 1, 2, 3, };
        string[] tekstArray = { "Hei", "på", "Deg" };
        List<int> liste = new List<int>();

        static void Main(string[] args)
        {
            Console.WriteLine(helTall);
            
        }
    }
}