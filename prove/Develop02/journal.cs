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

    }
    public void saveToFile(string file)
    {

    }
    public void LoadFromFile(string file)
    {

    }

}