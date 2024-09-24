using System.Text;


namespace Generics;

public class Stapel<T>
{
    private Stack<T> stack;

    
    public Stapel()
    {
        stack = new Stack<T>();
    }

    
    public void ZetOp(T item)
    {
        stack.Push(item);
    }

    
    public T HaalAf()
    {
        return stack.Count == 0 ? default(T) : stack.Pop();
    }

    
    public void LeegMaken()
    {
        stack.Clear();
    }

    
    public override string ToString()
    {
        if (stack.Count == 0)
        {
            return "Stapel is leeg";
        }

        StringBuilder sb = new StringBuilder();
        int indent = 0;
        foreach (T item in stack)
        {
            sb.Append(new string(' ', indent)).AppendLine(item.ToString());
            indent += 2;
        }
        return sb.ToString();
    }
}