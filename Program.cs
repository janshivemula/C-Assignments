namespace Boxing_Unboxing
{
    class BodyMass
    {
        static void Main(string[] args)
        {
            int weight = 38;
            object objweight = weight;
            Console.WriteLine("Boxed Weight: {0}", objweight);

            int unboxedweight = (int)objweight;
            Console.WriteLine("UnBoxed Weight: {0}", unboxedweight);
            Console.ReadLine();
        }
    }
}
