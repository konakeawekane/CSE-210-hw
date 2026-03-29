namespace NeuralNetwork;
using System.Collections.Generic;
using DataSet;

public abstract class NeuralNet
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

    protected void Evaluate(string entry, string exit, double[] inputs)
    {
        throw new NotImplementedException();
        
        // Start executing where the entry point is in the execution order

        // Run through every layer and evaluate the node values

        // Stop at the exit layer when reached or when the end of the execution order was reached (throw an error in the latter case)
    }

    public abstract string Evaluate();

    public abstract void Train(int iterations, IDataSet dataSet);

    public abstract double Test(IDataSet dataSet);
}