using static System.Collections.Stack;
namespace Otus_HomeWork_4
{
    public static class StackExtensions
    { 
        public static void Merge(this Stack stack,Stack stackAdd)
        {
            while (stackAdd.Top != null)
            {
                stack.Add(stackAdd.Top);
                stackAdd.Pop();
            }
        }
    }
}
