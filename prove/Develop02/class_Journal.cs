public class Journal{
    // List to contain the entry data. 
    public List<Entry> _entries = new List<Entry>();

    public void GetEntries()
    {
        //TODO:Code that iterates through list and prints data found.
        foreach(Entry entry in _entries)
        {
            Entry.DisplayEntry();
            }
        }
    
    //Code that will iterate through .txt file to find the prompts.
    public void GetPromptList(){
        string promptfilename="prompts.txt";
        string[] lines =System.IO.File.ReadAllLines(filename);
        foreach (string line in lines){
            string[] parts=line.Split("?");
        }
    }
}