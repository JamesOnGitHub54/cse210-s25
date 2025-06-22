public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public string AddEntry(Entry newEntry)
    {
        PromptGenerator prompt = new PromptGenerator();
        Console.WriteLine(prompt.GetRandomPrompt());
        Console.Write("> ");
        string entry = Console.ReadLine();
        return entry;
        
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {

    }

    public void LoadToFile(string file)
    {

    }
}