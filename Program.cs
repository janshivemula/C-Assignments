namespace InOut
{
    class InOut
    {
        static void ShowResult(in int num, out int result )
        {
            result = num * num;
        }
        static int Sum(params int[] numbers)
        {
            int sum = 0;
            for(int i =0; i< numbers.Length; i++)
            {
                sum = sum + numbers[i];
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("POC on In and Out Variables");
            int number = 5;
            int result;
            ShowResult(number, out result);
            Console.WriteLine("Number : " + number);
            Console.WriteLine("Result : " + result);
            Console.WriteLine();

            Console.WriteLine("POC on Params");
            int total = Sum(12, 05, 18, 10);
            Console.WriteLine("Sum : " + total);
            Console.WriteLine();

            Console.WriteLine("POC on Integer.TryParse()");
            string input = "123";
            int value;
            if(int.TryParse(input , out value))
            {
                Console.WriteLine("Conversion Successful : " + value);
            }
            else
            {
                Console.WriteLine("Invalid input given, give proper input");
            }
            Console.WriteLine();

            Console.WriteLine("WriteLine using params");
            Console.WriteLine("Name : {0}, Age : {1}", "Janaki", 23);

        }
        
    }
}
