namespace BoxingAndUnboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // boxing
            int i = 3;
            object obj1 = i;
            Console.WriteLine(i);
            Console.WriteLine(obj1);

            // unboxing
            int smallerNumber = 10;
            object obj2 = smallerNumber;
            if (obj2 is int)
            {
                long j = (int)obj2;
                Console.WriteLine(obj2);
                Console.WriteLine(j);
            }


            object obj3 = new Person();
            if (obj3 is string obj3Content)
            {
                Console.WriteLine(obj3Content);
            }
            

            // literals
            long a = 123;
            long b = -a;
            Console.WriteLine(a);
            Console.WriteLine(b);

            // operators
            string text = null;
            Console.WriteLine("Length of text:" + text?.Length);
           
        }
    }

    public class Person
    {
        public string Name;
    }
}