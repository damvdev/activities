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
        public static void Main()
        {
            // Test IsNatural
            Console.WriteLine(IsNatural(3));
            Console.WriteLine(IsNatural(-3));
            // Test IsNotNatural
            Console.WriteLine(IsNotNatural(3));
            Console.WriteLine(IsNotNatural(-3));
        }
    }
}