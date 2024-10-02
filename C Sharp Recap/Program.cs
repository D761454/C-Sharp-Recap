namespace C_Sharp_Recap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1
            Console.WriteLine("Hello, World!");

            // 2
            string input;
            float width = 0, height = 0;

            Console.WriteLine("Width:");
            while (width == 0)
            {
                input = Console.ReadLine();
                try
                {
                    width = float.Parse(input);
                }
                catch (FormatException)
                {
                    Console.WriteLine($"unable to parse '{input}'");
                }
            }



            Console.WriteLine("Height:");
            while (height == 0)
            {
                input = Console.ReadLine();
                try
                {
                    height = float.Parse(input);
                }
                catch (FormatException)
                {
                    Console.WriteLine($"unable to parse '{input}'");
                }
            }

            float area = width * height;
            float perimeter = (2 * width) + (2 * height);

            Console.WriteLine("Area: " + area + "; Perimeter: " + perimeter);

            // 3 & 4
            Console.WriteLine("Enter 10 integers");
            int[] numArray = new int[10];
            for (int i = 0; i < numArray.Length; i++)
            {
                int temp;
                string tempString;
                Console.WriteLine("Integer " + i);
                tempString = Console.ReadLine();
                try
                {
                    temp = int.Parse(tempString);
                }
                catch (FormatException)
                {
                    Console.WriteLine($"unable to parse '{tempString}'");
                }
            }
        }
    }
}
