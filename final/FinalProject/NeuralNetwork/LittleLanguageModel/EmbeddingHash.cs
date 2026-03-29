namespace NeuralNetwork.LittleLanguageModel;
using System.Collections.Generic;
using System.IO;

public class EmbeddingHash
{
    private Dictionary<string, double[]> _vocabularyHash;
    private int _dimentions;

    public EmbeddingHash(int dimentions)
    {
        _dimentions = dimentions;
        _vocabularyHash = new Dictionary<string, double[]>();
    }

    public EmbeddingHash(string importPath)
    {
        _vocabularyHash = new Dictionary<string, double[]>();
        ImportVocabulary(importPath);

        throw new NotImplementedException();

        // currently import vocab is not implemented
    }

    public int GetDimentions()
    {
        return _dimentions;
    }

    public void ImportVocabulary(string externalFile)
    {
        string load = File.ReadAllText(externalFile);

        load.Split(",");

        throw new NotImplementedException();

        // grab the first value and pass it in as the number of dimentions

        // parse saved vocabulary hash into a <string, double[]> dictionary
    }

    public void SaveVocabulary(string externalFile)
    {
        string save = _dimentions.ToString();

        foreach(KeyValuePair<string, double[]> hash in _vocabularyHash)
        {
            save += "," + hash.Key + "," + hash.Value;
        }

        File.WriteAllText(externalFile, save);
    }

    public double[] GetVector(string text)
    {
        return _vocabularyHash[text];
    }

    public bool Contains(string text)
    {
        return _vocabularyHash.ContainsKey(text);
    }

    public void AddWord(string text)
    {
        _vocabularyHash.Add(text,new double[_dimentions]);
    }
}