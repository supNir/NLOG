namespace Prac_2
{
    public class Program
    {
        public static void Main(String[] args)
        {
            var p = new Program();
            double x = 519313212;
            p.multiplication(x);
        }

        public void multiplication(double n)
        {
            try
            {
                while (true)
                {
                    n *= n;
                    if (double.IsInfinity(n))
                    {
                        throw new OverflowException("Переполнение при умножении");
                    }
                    Console.WriteLine(n);
                }
            }
            catch (OverflowException overE)
            {
                Console.WriteLine(overE.Message);
            }
        }
    }
}