using System;

namespace PasseioCavaloBT{
    class Program
    {
        static void Main(string[] args)
        {
            PasseioCavalo galopeira = new PasseioCavalo(5);
            galopeira.imprimirPasseio(0, 0);
            Console.ReadKey();
        }
    }
}
