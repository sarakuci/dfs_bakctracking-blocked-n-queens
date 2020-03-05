using System;

namespace DFS_Backtracking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Blocked N-Queens DFS-Backtracking: \n");
            Console.Write("Shtypni numrin e mbretereshave: ");
            int n = int.Parse(Console.ReadLine());
            Queen.Enumerate(n);
        }
    }
}
