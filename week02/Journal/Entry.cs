using System;

public class Entry
{
    public string _date = DateTime.Now.ToString("yyyy-MM-dd"); 
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine($"{_date} \n{_promptText}");
        Console.WriteLine($"- Response: \n{_entryText}");
        Console.WriteLine();
    }
}






