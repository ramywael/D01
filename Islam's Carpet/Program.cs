namespace Islam_s_Carpet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint estimateValidation = 30;
            uint pricePerSRoom = 25;
            uint pricePerLRoom = 35;
            Console.WriteLine("Number of small carpets:");
            uint smallRoom=Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Number of large  carpets:");
            uint bigRoom = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine( $"Price per small room :${pricePerSRoom}" );
            Console.WriteLine($"Price per small room :${pricePerLRoom}");
            uint cost = ((smallRoom * pricePerSRoom) + (bigRoom * pricePerLRoom));
            Console.WriteLine($"The cost is : {cost}");
            double tax = cost * 0.06;
            Console.WriteLine($"Tax is :  ${tax}"  );
            Console.WriteLine("===============================");
            double totalEstimate = tax + cost;
            Console.WriteLine($"Total estimate:{totalEstimate}");
            Console.WriteLine($"This estimate is valid for {estimateValidation} days");

        }
    }
}
