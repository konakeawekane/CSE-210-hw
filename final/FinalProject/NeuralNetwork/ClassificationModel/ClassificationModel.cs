using NeuralNetwork.DataSet;

namespace NeuralNetwork.ClassificationModel;

public class ClassificationModel : NeuralNet
{
    private Dictionary<int, string> _classifications;
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

    public override string Evaluate()
    {
        throw new NotImplementedException();

        // call the parent evaluate method with the proper inputs

        // return the computed value
    }

    public override void Train(int iterations, IDataSet dataSet)
    {
        throw new NotImplementedException();

        // Apply random variation to all of the weights and biases in the network

        // Use the given dataSet to pass in cases into the input layer

        // evaluate and calculate the individual cost per output node and the per case cost using the dataSets solutions

        // using the backpropagation algorithim apply corrective adjustments to each weight and bias 
    }

    public override double Test(IDataSet dataSet)
    {
        throw new NotImplementedException();
    }
}