public class Entry{
    public string _userDate;
    public string _userPrompt;
    public string _userEntry;

    
    public void GetPrompt(){
        //TODO: Code that will read prompt from list of prompts.
    }
    public void GetUserEntry(){
        //TODO:Code that will allow user to input text.
    }
    public void DisplayEntry(){
        Console.WriteLine(@$"
        Date: {_userDate}
        Prompt Used: {_userPrompt}
        Entry Found: {_userEntry}");
    }
}