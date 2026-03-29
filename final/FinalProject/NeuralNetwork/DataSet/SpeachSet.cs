namespace NeuralNetwork.DataSet;
using System.IO;

public class SpeachSet : IDataSet
{
    private string _data;
    private List<string> _messages;
    private List<List<string>> _cases;

    public SpeachSet(string file)
    {
        _cases = new List<List<string>>();
        _data = "";
        LoadFile(file);
    }

    public void LoadFile(string file)
    {
        _data = File.ReadAllText(file);
        _messages = _data.Split(",").ToList<string>();
    }

    public string GetCase(int index)
    {
        return _cases[index].ToString();
    }

    public string GetTruth(int index)
    {
        throw new NotImplementedException();
    }
}