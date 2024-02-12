namespace parse_random
{
    internal class Program
    {
        
        static int Reader()
        {
            int a;
            string input;
            do
            {
                Console.WriteLine("adj 1 szamot");
            } while (!int.TryParse(Console.ReadLine(), out a));

            return a;
        }
        
        static int Summ (int a, int b)
        {
            return a + b;
        }

        static void Summ2(int a, int b, out int c)
        {
           c = a + b;
        }

        static void Summ3(int a, int b, ref int d)
        {
            d = a + b;
        }
        static void Main(string[] args)
        {
            
            
            
;            //a = int.Parse(input);
            
            int a = Reader();
            int b = Reader();

            int summ = Summ(a, b);

            int c;
            Summ2(a, b, out c);

            int d = 10; //ref nek kell be is, out nak csak ki, cserenel jo a ref, parse nal nem kell bemeno
            Summ3 (a, b, ref d);
        }
    }
}