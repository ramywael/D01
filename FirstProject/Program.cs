namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
           int value = 21;
            Console.WriteLine(value);
            char letter = 'R';
            Console.WriteLine($"The Letter Is : {letter}"); //this is best for cpu (ELU) and is called string enterpolation
                                                          
            Console.WriteLine("The Letter Is : "+letter);    //Also it can be solved like this but is not a best solution


            string? name=Console.ReadLine(); //This is how we read from c#
            Console.WriteLine(name);


            int value1= Convert.ToInt32(Console.ReadLine()); // if we need to read the value1 as  it is int we need to convert the string the user enter and then convert it to the identifier which is int 
            Console.WriteLine(value1);

        }
    }
}
