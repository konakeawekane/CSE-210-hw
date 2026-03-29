namespace NeuralNetwork.LittleLanguageModel.AIContext;
using System.Data;

public class Context
{
    private List<Token> _tokens;
    private int _size;

    public Context(int size)
    {
        _size = size;
        _tokens = new List<Token>(size);
    }

    public void PushInput(List<Token> input)
    {
        foreach(Token token in input)
        {
            _tokens.Prepend(token);
        }
        if(_tokens.Count > _size)
        {
            _tokens.RemoveRange(_size + 1, _tokens.Count - 1);
        }
    }

    public List<Token> GetTokens()
    {
        return _tokens;
    }
}