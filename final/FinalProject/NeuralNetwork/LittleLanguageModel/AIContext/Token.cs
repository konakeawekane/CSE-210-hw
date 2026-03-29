namespace NeuralNetwork.LittleLanguageModel.AIContext;
using LittleLanguageModel;

public class Token
{
    private string _text;

    public Token(string text, EmbeddingHash vocabularySet)
    {
        _text = text;
        if(!vocabularySet.Contains(text)) {vocabularySet.AddWord(text);}
    }
    
}