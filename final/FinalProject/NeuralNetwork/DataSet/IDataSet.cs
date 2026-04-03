namespace NeuralNetwork.DataSet;

public interface IDataSet<T>
{
    void LoadFile(string file);
    T GetCase(int index);
    T GetTruth(int index);
}