namespace NeuralNetwork;

public class Layer
{
    int _size;
    private double[] _nodes;
    private double[] _weights;
    private double[] _biases;

    public Layer(int size)
    {
        _size = size;
        _nodes = new double[size];
        _biases = new double[size];
    }

    public Layer(int size, int prevSize)
    {
        _size = size;
        _nodes = new double[size];
        _biases = new double[size];
        resizeWeights(prevSize);
    }

    public void resizeWeights(int prevSize)
    {
        _weights = new double[_size * prevSize];
    }

    public double[] GetNodes()
    {
        return _nodes;
    }

    public double[] GetWeights()
    {
        return _weights;
    }

    public double[] GetBiases()
    {
        return _biases;
    }

    public void SetNodes(double[] input)
    {
        if(input.Length != _nodes.Length)
        {
            throw new Exception("layer dimension missmatch");
        }
        else
        {
            _nodes = input;
        }
    }
    public void PushWeights(double[] modulations)
    {
        for(int i = 0; i < _weights.Length; i++)
        {
            _weights[i] += modulations[i];
        }
    }

    public void PushBiases(double[] modulations)
    {
        for(int i = 0; i < _biases.Length; i++)
        {
            _biases[i] += modulations[i];
        }
    }

    public void Evaluate(Layer previousLayer)
    {   
        //reads the values from the input layer
        double[] prevNodes = previousLayer.GetNodes();
        int prevSize = prevNodes.Length;
        int weightIndex = 0;
        
        //iterates over each node calculating value
        for(int i = 0; i < _size; i++)
        {
            double newValue = 0;

            //iterates over each previous node and multiplies node by weight
            for(int j = 0; j < prevSize; j++)
            {
                newValue += prevNodes[j] * _weights[weightIndex];
                weightIndex ++;
            }
            newValue += _biases[i];  //adds the bias

            _nodes[i] = newValue;
        }
    }

}