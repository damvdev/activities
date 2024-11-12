using System;
namespace Activities {
    public class Program {
        public static bool IsNatural(int num) {
            return num > 0;
        }
        public static void Main()
        {
            Console.WriteLine(IsNatural(3));
            Console.WriteLine(IsNatural(-3));
        }
    }
}