using NeuralNetwork.DataSet;

namespace NeuralNetwork.ClassificationModel;

public class ClassificationModel : NeuralNet<double[]>
{
    private Dictionary<int, string> _classifications;

    private double _learnRateRandom;
    public ClassificationModel(int inputs, Dictionary<int, string> classifications) : 
        base(new Dictionary<string, Layer>
            {
                { "input", new Layer(inputs)},
                { "output", new Layer(classifications.Count)}
            }, new List<string>
            {
                "input",
                "output"
            }
        )
    {
        _classifications = classifications;
        ReBuildWeights();
    }

    public void AddHiddenLayer(int size)
    {
        string newLayerName = $"hidden {GetAllLayers().Count}";
        AddLayer("hidden", new Layer(size));
    }

    public override double[] Evaluate(double[] input)
    {

        // call the parent evaluate method with the proper inputs
        Process("input", "output", input);

        // return the computed value
        return GetLayer("output").GetNodes();
    }

    public override void Train(int iterations, IDataSet<double[]> dataSet)
    {
        // Apply random variation to all of the weights and biases in the network
        foreach(Layer layer in GetAllJustLayers())
        {
            layer.PushWeights(Noise(_learnRateRandom, layer.GetWeights().Length));
            layer.PushBiases(Noise(_learnRateRandom, layer.GetBiases().Length));
        }

        // Use the given dataSet to pass in cases into the input layer
        Random random = new Random();
        int caseID = random.Next(((ClassificationSet)dataSet).GetNumberOfCases());
        GetLayer("input").SetNodes(dataSet.GetCase(caseID));  // how to parse from string to array
        

        // evaluate and calculate the individual cost per output node and the per case cost using the dataSets solutions

        // using the backpropagation algorithim apply corrective adjustments to each weight and bias 
        throw new NotImplementedException();
    }

    public override double Test(IDataSet<double[]> dataSet)
    {
        throw new NotImplementedException();
    }


    // helper functions to clean up code appearance
    private double[] Noise(double magnitude, int arraySize)
    {
        Random random = new Random();
        double[] result = new double[arraySize];

        for(int i = 0; i < arraySize; i++)
        {
            result[i] = (random.NextDouble() * 2.0 - 1.0) * magnitude;
        }
        
        return result;
    }
}