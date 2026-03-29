namespace NeuralNetwork.DataSet;
using System.IO;

public class MusicSet : IDataSet
{
    
    public MusicSet(string file)
    {
        LoadFile(file);
        throw new NotImplementedException();
    }

    public void LoadFile(string file)
    {
        
    }

    public string GetCase(int index)
    {
        throw new NotImplementedException();

        // return an item from data at the index packed into a string
    }

    public string GetTruth(int index)
    {
        throw new NotImplementedException();

        // return an item drom the results at the index packed into a string
    }
}