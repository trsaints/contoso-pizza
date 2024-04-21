namespace ContosoPizza.Models;

public class Pizza(int id, string? name, bool isGlutenFree)
{
    public int Id
    {
        get => id;
        set => id = value;
    }

    public string? Name
    {
        get => name;
        set => name = value;
    }
    
    public bool IsGlutenFree
    {
        get => isGlutenFree;
        set => isGlutenFree = value;
    }
}