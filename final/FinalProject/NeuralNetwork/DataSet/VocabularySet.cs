namespace NeuralNetwork.DataSet;
using System.IO;

public class VocabularySet : IDataSet
{
    private List<string> _compareListOne;
    private List<string> _compareListTwo;
    private List<bool> _compareTruth;
    
    public VocabularySet(string file)
    {
        LoadFile(file);
        _compareListOne = new List<string>();
        _compareListTwo = new List<string>();
        _compareTruth = new List<bool>();
        throw new NotImplementedException();
    }

    public void LoadFile(string file)
    {
       _compareListOne = new List<string>();
       _compareListTwo = new List<string>();
       throw new NotImplementedException();
    }

    public string GetCase(int index)
    {
        throw new NotImplementedException();
    }

    public string GetTruth(int index)
    {
        throw new NotImplementedException();
    }
}