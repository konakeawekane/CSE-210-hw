namespace NeuralNetwork.LittleLanguageModel;
using AIContext;
using NeuralNetwork.DataSet;

public class LLM : NeuralNet<string>
{
    private Context _context;
    private EmbeddingHash _vocabulary;

    public LLM(int contextWindow, int embeddingHashDimensions) : 
        base(new Dictionary<string, Layer>
            {
                { "input", new Layer(contextWindow * embeddingHashDimensions)},
                { "output", new Layer(embeddingHashDimensions)}
            }, new List<string>
            {
                "input",
                "output"
            }
        )
    {
        _context = new Context(contextWindow);
        _vocabulary = new EmbeddingHash(embeddingHashDimensions);
        ReBuildWeights();
    }
    public LLM(int contextWindow, EmbeddingHash vocab) : 
        base(new Dictionary<string, Layer>
            {
                { "input", new Layer(contextWindow * vocab.GetDimentions())},
                { "output", new Layer(vocab.GetDimentions())}
            }, new List<string>
            {
                "input",
                "output"
            }
        )
    {
        _context = new Context(contextWindow);
        _vocabulary = vocab;
        ReBuildWeights();
    }

    public override string Evaluate(string input)
    {
        throw new NotImplementedException();

        // call the parent evaluate method with the proper inputs

        
    }

    public override void Train(int iterations, IDataSet<string> dataSet)
    {
        throw new NotImplementedException();

        // repeat for the iteraction count vv

        // get a case from the dataSet

        // randomize network (based on learn rate)

        // evaulate network

        // get the truth from the same case in the dataSet

        // calculate total network cost (inaccuracy)

        // use backpropogation algorithim to apply corrective adjustments (also based on learn rate)
    }

    public override double Test(IDataSet<string> dataSet)
    {
        throw new NotImplementedException();

        // get a case from the dataSet (should be separate from the training set)

        // evaulate network

        // get the truth from the same case in the dataSet

        // calculate total network cost (inaccuracy)

        // return cost (inaccuracy) to be used for tuning the learn rate and evaluating learning progress
    }
}