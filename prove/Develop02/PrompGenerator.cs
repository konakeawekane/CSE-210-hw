using System.IO;

public class PromptGenerator
{
    public List<string> _prompts;

    public int _index;

    // Prompt Generator constructer script Loads prompts from an external txt file.
    // If file Prompts.txt not found 10 prompts are automatically loaded.
    public PromptGenerator()
    {
        _index = 0;
        _prompts = new List<string>();
        try
        {
            string[] file = System.IO.File.ReadAllLines("Prompts.txt");
            foreach(string line in file)
            {
                _prompts.Add(line);
            }

        } catch (System.IO.FileNotFoundException)
        {
            _prompts.Add("If I had one thing I could do over again today, what would it be?");
            _prompts.Add("What was the best part of my day?");
            _prompts.Add("Who was the most interesting person I interacted with today?");
            _prompts.Add("If you could send a 30-second voice note to your 80-year-old self, what would you say?");
            _prompts.Add("If you met yourself for the first time today, what would your first impression be?");
            _prompts.Add("What was the \"High\" and the \"Low\" of your day?");
            _prompts.Add("If you had to describe today's mood, what would it be?");
            _prompts.Add("What was the most unexpected thing that that happened today?");
            _prompts.Add("What was the hardest task you accomplished today?");
            _prompts.Add("What is one thing you did today that your future self will thank you for?");

        }
    }

    // returns a new random prompt different from the current prompt
    public string NextPrompt()
    {
        Random rng = new Random();
        int newIndex = _index;
        while(newIndex == _index) {newIndex = rng.Next(1,_prompts.Count);}
        _index = newIndex;
        return _prompts[_index];
    }
}