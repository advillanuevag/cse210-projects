public class Journal
{
    public List<Entry> _entries;
    public Journal()
    {
        _entries = new List<Entry>(); //Inicializes the List of Entries.
    }
    
    
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
        

    }
    public void DisplayAll()
    {
        foreach (var entry in _entries)//Act
            {
                entry.Display();
            }
        //Console.WriteLine($"This goes Option 4 Code when ready... ");

    }
    public void saveToFile(string file)
    {

    }
    public void LoadFromFile(string file)
    {
        //Act

    }

}