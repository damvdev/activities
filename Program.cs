using System;
namespace Activities {
    public class Program {
        public static bool IsNatural(int num) {
            return num > 0;
        }
        public static bool IsNotNatural(int num)
        {
            return !IsNatural(num);
        }
        public static int PowIt(int m, int n)
        {
            int num = 1;
            for (int i = 0; i < n; i++)
            {
                num *= m;
            }
            return num;
        }
        public static void Main()
        {
            // Test IsNatural
            Console.WriteLine(IsNatural(3));
            Console.WriteLine(IsNatural(-3));
            // Test IsNotNatural
            Console.WriteLine(IsNotNatural(3));
            Console.WriteLine(IsNotNatural(-3));
            // Test PowIt
            Console.WriteLine(PowIt(2, 3));
        }
    }
}