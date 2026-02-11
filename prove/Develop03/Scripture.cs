public class Scripture
{
    private Referance _scriptureReferance;
    private List<Word> _text = new List<Word>();
    private List<int> hiddenIndices = new List<int>();

    public Scripture(Referance inReferance, List<Word> inText)
    {
        _scriptureReferance = inReferance;
        _text = inText;
    } 

    //alternate constructor that takes a single string and splits it into words using spaces as the dilimiter.
    public Scripture(Referance inReferance, string inText)
    {
        _scriptureReferance = inReferance;

        string[] words = inText.Split(" ");

        foreach(string word in words)
        {
            Word newWord = new Word(word);
            _text.Add(newWord);
        }
    }

    public void Display()
    {
        Console.Write(_scriptureReferance.GetReferance() + " ");
        foreach (Word word in _text)
        {
            Console.Write(word.GetString() + " ");
        }
        Console.WriteLine();
    }

    //hides n number of words
    public bool HideN(int n)
    {
        List<int> validIndices = new List<int>();
        bool allHid = true;

        //gets all of the indices of word that are not hidden
        for(int i = 0; i < _text.Count; i++)
        {
            if (!_text[i].GetHid())
            {
                validIndices.Add(i);
                allHid = false;
            }
        }
        //Exits if all words are already hidden
        if(allHid == true){return allHid;}

        //Begins hiding indices of not hidden words and exits if it runs out of not hidden words
        Random random = new Random();
        for(int i = 0; i < n; i++)
        {
            int index = random.Next(0,validIndices.Count);
            _text[validIndices[index]].Hide();
            hiddenIndices.Add(validIndices[index]);
            validIndices.RemoveAt(index);
            if(validIndices.Count == 0){break;}
        }
        //makes sure that the indices are in assending order.
        hiddenIndices.Sort();

        //Returns that the scripture was not already completely hidden.
        return allHid;
    }

    public void DisplayHint()
    {
        if(!(hiddenIndices.Count == 0))
        {
            Random random = new Random();
            int hintIndexPosition = random.Next(0,hiddenIndices.Count);
            int hintIndex = hiddenIndices[hintIndexPosition];
            char hint = _text[hintIndex].GetHint();
            Console.WriteLine($"Hint: Letter 1 of hidden word {hintIndexPosition + 1} is {hint}. Press enter to hide hint.");
        } else
        {
            Console.WriteLine($"No words hidden yet (I think you got it). Press enter to hide hint.");
        }
    }
}