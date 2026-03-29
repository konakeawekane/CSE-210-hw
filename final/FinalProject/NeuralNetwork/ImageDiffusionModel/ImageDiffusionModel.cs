using NeuralNetwork.DataSet;

namespace NeuralNetwork.ImageDiffusionModel;

public class ImageDiffusionModel : NeuralNet
{

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