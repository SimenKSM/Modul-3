namespace ConsoleApp4
{
    internal class Program
    {
        public static string[] letters = { "a", "b", "c", "d", "e", "f" };
        public static string[] vowels = { "a", "e", "i", "o", "u", "y" };
        public static int[] numbers = { 1, 2, 3 };
        
        public static List<int> nums = new List<int> { 1, 2, 3 };

        static void Main(string[] args) {
            int counter = 0;
            int vowelscount = 0;
            int numberSum = 0;
        
            for (int i = 0; i < letters.Length; i++)
            {
               counter++;
            }
            Console.WriteLine(counter);

            for (int i = 0; i < letters.Length; i++)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (letters[i] == vowels[j])
                    {
                        vowelscount++;
                    }
                }
            } 
            Console.WriteLine(vowelscount);
            Console.WriteLine("Skriv et jævla tall");
            string input = Console.ReadLine(); 
           int inputvalue = Convert.ToInt32(input);
           nums.Add(inputvalue);
            


            for (int i = 0; i < nums.Count; i++)
            {
                numberSum += nums[i];
               // Console.WriteLine(numbers[i]);
                Console.WriteLine(numberSum);
            }
            
            Console.WriteLine(numberSum);


            










        }
    }
}