public class Entry{
    public string _userDate;
    public string _userPrompt;
    public string _userEntry;


    public void Display_Entry()
    {
        Console.WriteLine(@$"
        Date:{_userDate}
        Prompt: {_userPrompt}
        Entry: {_userEntry}");
    }
}

