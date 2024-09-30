using System;
using System.Collections.Generic;

public class Stapel<T>
{
    // Event dat wordt getriggerd bij wijzigingen in de stapel
    public event Action<string, T> StapelGewijzigd;

    private Stack<T> _stack = new Stack<T>();

    // Methode om een item toe te voegen
    public void Toevoegen(T item)
    {
        _stack.Push(item);
        OnStapelGewijzigd("Toevoeging", item);
    }

    // Methode om een item te verwijderen
    public T Verwijderen()
    {
        if (_stack.Count == 0)
        {
            throw new InvalidOperationException("De stapel is leeg.");
        }
        T item = _stack.Pop();
        OnStapelGewijzigd("Verwijdering", item);
        return item;
    }

    // Methode om de stapel leeg te maken
    public void Leegmaken()
    {
        _stack.Clear();
        OnStapelGewijzigd("Leegmaken", default(T));
    }

    // Event trigger helper
    protected virtual void OnStapelGewijzigd(string actie, T item)
    {
        StapelGewijzigd?.Invoke(actie, item);
    }

    // ToString om de inhoud van de stapel te tonen
    public override string ToString()
    {
        return $"Stapel bevat {_stack.Count} items.";
    }
}