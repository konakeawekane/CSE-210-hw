namespace NeuralNetwork.DataSet;
using System.IO;

public class ClassificationSet : IDataSet
{
    //classification sets need cases with inputs that lead to one of many classifications (outputs)
    private List<double[]> _data;
    private List<double[]> _result;
    private int _dataWidth;
    private int _resultWidth;
    
    public ClassificationSet(string file)
    {
        LoadFile(file);
        throw new NotImplementedException();
    }

    public void LoadFile(string file)
    {
        List<string> lines = File.ReadLines(file).ToList<string>();
        if(lines[0] == "Classification")
        {
            _dataWidth = int.Parse(lines[1]);
            _resultWidth = int.Parse(lines[2]);
            _data = new List<double[]>();
            _result = new List<double[]>();
            string[] line;
            for(int i = 3; i < lines.Count; i++)
            {
                line = lines[i].Split(",");
                double[] inputData = new double[_dataWidth];
                double[] outputResult = new double[_resultWidth];

                for(int j = 0; j < _dataWidth; j++) {inputData[j] = double.Parse(line[j]);}
                for(int j = _dataWidth; j < _dataWidth + _resultWidth; j++) {outputResult[j] = double.Parse(line[j]);}

                _data.Add(inputData);
                _result.Add(outputResult);
            }
        }
        else
        {
            throw new Exception("Invalid File Format");
        }
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