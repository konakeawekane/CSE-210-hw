namespace NeuralNetwork;
using System.Collections.Generic;
using DataSet;

public abstract class NeuralNet<T>
{
    private Dictionary<string, Layer> _layers;
    private List<string> _executionOrder;
    private bool _layersDirtied;
    
    //Constructors
    public NeuralNet()
    {
        _layers = new Dictionary<string, Layer>();
        _executionOrder = new List<string>();
        _layersDirtied = true;
    }
    
    public NeuralNet(Dictionary<string, Layer> layers, List<string> executionOrder)
    {
        _layers = layers;
        _executionOrder = executionOrder;
    }

    public void ReBuildWeights()
    {
        for(int i = 1; i < _executionOrder.Count - 1; i++)
        {
            _layers[_executionOrder[i]].resizeWeights(_layers[_executionOrder[i - 1]].GetNodes().Length);
        }
        _layersDirtied = false;
    }

    public bool GetNeedsRebuilding()
    {
        return _layersDirtied;
    }

    public Layer GetLayer(string name)
    {
        return _layers[name];
    }

    public void AddLayer(string name, Layer layer)
    {
        _layers.Add(name, layer);
        _layersDirtied = true;
    }

    public Dictionary<string, Layer> GetAllLayers()
    {
        return _layers;
    }

    public List<Layer> GetAllJustLayers()
    {
        return _layers.Values.ToList();
    }

    public List<string> GetExecutionOrder()
    {
        return _executionOrder;
    }

    public void RemoveLayerFromExecutionOrder(string layerName)
    {
        _executionOrder.Remove(layerName);
        _layersDirtied = true;
    }

    public void SetLayerExecutionOrder(string layerName, int index)
    {
        if (_executionOrder.Contains(layerName))
        {
            _executionOrder.Remove(layerName);   
        }
        int insertIndex = Math.Min(_executionOrder.Count + 1, index);
        _executionOrder.Insert(insertIndex, layerName);
        _layersDirtied = true;
    }

    protected void Process(string entry, string exit, double[] input)
    {
        // Start executing where the entry point is in the execution order
        int index = _executionOrder.IndexOf(entry);
        string currentLayer;
        string lastLayer = _executionOrder[index];

        // Pass in inputs
        GetLayer(lastLayer).SetNodes(input);
        
        // Run through every layer and evaluate the node values
        while (index < _executionOrder.Count && !(_executionOrder[index] == exit))
        {
            index++;
            currentLayer = _executionOrder[index];
            _layers[currentLayer].Evaluate(_layers[lastLayer]);
            lastLayer = currentLayer;
        }    
    }

    public abstract T Evaluate(T input);

    public abstract void Train(int iterations, IDataSet<T> dataSet);

    public abstract double Test(IDataSet<T> dataSet);

    public abstract string Serialize();

    public abstract void Deserialize(string contents);
}