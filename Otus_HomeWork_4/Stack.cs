using static System.Collections.Stack;
namespace Otus_HomeWork_4
{
    public class Stack
    {
        private List<string> _list = new List<string>();
        public string Top = null;
        public int Size = 0;
        public Stack(params string[] localList)
        {
            for (int i = 0; i < localList.Length; i++)
            {
                _list.Add(localList[i]);
                Size++;
                Top = localList[i];
            }
        }
        public void Add(string element)
        {
            _list.Add(element);
            Size++;
            Top = element;
        }
        public string Pop()
        {
            if (Top == null)
            {
                Console.WriteLine("Стек пустой");
                return "";
            }
            if (_list.Count > 1)
            {
                _list.Remove(_list.Last());
                Size--;
                Top = _list.Last();
                return Top;
            }
            else
            {
                Top = null;
                Size--;
                _list.Remove(_list.Last());
                return "";
            }
        }
        public static List<string> Concat(params Stack[] stack)
        {
            List<string> listStack = new List<string>();

            foreach (var item in stack)
            {
                while (item.Top != null)
                {
                    listStack.Add(item.Top);
                    item.Pop();
                }
            }
            return listStack;
        }
    }
}
