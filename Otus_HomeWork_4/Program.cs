
using System.Runtime.Intrinsics.Arm;

namespace Otus_HomeWork_4
{
    class Program
    {
        static void Main(string[] arg)
        {
            var s = new Stack("a", "b", "c");
            Console.WriteLine($"size = {s.Size}, Top = '{s.Top}'");
            var deleted = s.Pop();
            Console.WriteLine($"Извлек верхний элемент '{deleted}' Size = {s.Size}");
            s.Add("d");
            Console.WriteLine($"size = {s.Size}, Top = '{s.Top}'");
            s.Pop();
            s.Pop();
            s.Pop();
            Console.WriteLine($"size = {s.Size}, Top = {(s.Top == null ? "null" : s.Top)}");
            s.Pop();
            
            var s1 = new Stack("a", "b", "c");
            s1.Merge(new Stack("1", "2", "3"));
            Console.WriteLine($"size = {s1.Size}, Top = '{s1.Top}'");
            
            
            var s2 = Stack.Concat(new Stack("a", "b", "c"), new Stack("1", "2", "3"), new Stack("А", "Б", "В"));
        }
    }

}