namespace NeuralNetwork.DataSet;

public interface IDataSet
{
    void LoadFile(string file);
    string GetCase(int index);
    string GetTruth(int index);
}