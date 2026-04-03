namespace NeuralNetwork.DataSet;
using System.IO;

public class ImageSet : IDataSet<double[]>
{
    
    public ImageSet(string file)
    {
        LoadFile(file);
        throw new NotImplementedException();
    }

    public void LoadFile(string file)
    {
        
    }

    public double[] GetCase(int index)
    {
        throw new NotImplementedException();

        // return an item from data at the index packed into a string
    }

    public double[] GetTruth(int index)
    {
        throw new NotImplementedException();

        // return an item drom the results at the index packed into a string
    }
}