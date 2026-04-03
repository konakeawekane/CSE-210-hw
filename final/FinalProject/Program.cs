using System;
using System.IO;
using NeuralNetwork;
using NeuralNetwork.DataSet;
using NeuralNetwork.LittleLanguageModel;
using NeuralNetwork.LittleLanguageModel.AIContext;
using NeuralNetwork.ClassificationModel;
using NeuralNetwork.ImageDiffusionModel;
using NeuralNetwork.MusicDiffusionModel;

class Program
{
    static bool isRunning = true;
    static string input;
    static List<string> modelNames = new List<string>{"Classification", "Language", "ImageDiffusion"," MusicDiffusion"};
    static List<string> dataSetTypes = new List<string>{"Classification", "Language", "Image", "Music"};

    static List<IDataSet<string>> languageDataSets = new List<IDataSet<string>>();
    static List<IDataSet<double[]>> numericalDataSet = new List<IDataSet<double[]>>();
    static List<NeuralNet<string>> languageNetworks = new List<NeuralNet<string>>();
    static List<NeuralNet<double[]>> numaricalNetworks = new List<NeuralNet<double[]>>();

    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome.");
        Console.WriteLine();
        Thread.Sleep(1000);

        while (isRunning)
        {
            Console.Clear();
            Menu();
            Thread.Sleep(1000);
        }
    }

    static void Menu()
    {
        Console.WriteLine("Main Menu options: ");
        Console.WriteLine("   1) Import Items");
        Console.WriteLine("   2) Export Items");
        Console.WriteLine("   3) Run Items");
        Console.WriteLine("   4) Create Items");
        Console.WriteLine("   5) Quit Program");
        Console.Write("Enter the number of the option then press enter: ");

        input = Console.ReadLine();
        Console.WriteLine();

        switch (input)
        {
            case("1"):
                Console.Clear();
                DispalyImportMenu();
                break;

            case("2"):
                Console.Clear();
                DispalyExportMenu();
                break;

            case("3"):
                Console.Clear();
                DispalyRunMenu();
                break;

            case("4"):
                Console.Clear();
                DisplayCreateMenu();
                break;

            case("5"):
                isRunning = false;
                break;

            default:
                Console.WriteLine("Invalid input");
                break;
        }
    }

    static void DispalyImportMenu()
    {
        Console.WriteLine("Import options: ");
        Console.WriteLine("   1) Import Neural Network");
        Console.WriteLine("   2) Import DataSet");
        Console.WriteLine("   3) Back");
        Console.Write("Enter the number of the option then press enter: ");

        input = Console.ReadLine();
        Console.Clear();

        switch (input)
        {
            case("1"):
                Console.Write("Valid Models - (");
                foreach(string name in modelNames){Console.Write(name + ", ");}
                Console.WriteLine(")");

                Console.Write("Enter Network Model type: ");
                string modelToImport = Console.ReadLine();

                if (modelNames.Contains(modelToImport))
                {
                    Console.Write("Enter File Path: ");
                    string filePath = Console.ReadLine();
                    string[] fileData;

                    // Read lines from file
                    try
                    {
                        fileData = File.ReadAllLines(filePath);
                    }
                    catch (FileNotFoundException)
                    {
                        Console.WriteLine("Error! File not found!");
                        break;
                    }
                    
                    // use a switch to create the needed model based on the declared type
                    switch (modelToImport)
                    {
                        case("Classification"):
                            numaricalNetworks.Add(new ClassificationModel(fileData));
                            break;
                        case("Language"):
                            languageNetworks.Add(new LLM(fileData));
                            break;
                        case("ImageDiffusion"):
                            numaricalNetworks.Add(new ImageDiffusionModel(fileData));
                            break;
                        case("MusicDiffusion"):
                            numaricalNetworks.Add(new MusicDiffusionModel(fileData));
                            break;
                    }
                    Console.WriteLine($"Successfully Imported {modelToImport} Network");
                }
                else
                {
                    Console.WriteLine("Invalid Model Name");
                }
                break;

            case("2"):
                Console.Write("Valid Types - (");
                foreach(string type in dataSetTypes){Console.Write(type);}
                Console.WriteLine(")");

                Console.Write("Enter DataSet Type: ");
                string dataSetType = Console.ReadLine();

                if (dataSetTypes.Contains(dataSetType))
                {
                    Console.Write("Enter File Path: ");
                    string filePath = Console.ReadLine();
                    
                    // use a switch to create the needed model based on the declared type
                    switch (dataSetType)
                    {
                        case("Classification"):
                            numericalDataSet.Add(new ClassificationSet(filePath));
                            break;
                        case("Language"):
                            languageDataSets.Add(new SpeachSet(filePath));
                            break;
                        case("Image"):
                            numericalDataSet.Add(new ImageSet(filePath));
                            break;
                        case("Music"):
                            numericalDataSet.Add(new MusicSet(filePath));
                            break;
                    }

                    Console.WriteLine($"Successfully Imported {dataSetType} Data Set");
                }
                else
                {
                    Console.WriteLine("Invalid DataSet Type");
                }
                break;

            case("3"):
                break;

            default:
                Console.WriteLine("Invalid input");
                break;
        }
    }

    static void DispalyExportMenu()
    {
        Console.WriteLine("Export options: ");
        Console.WriteLine("   1) Export Neural Network");
        Console.WriteLine("   2) Export Vocabulary Embbeding Hash");
        Console.WriteLine("   3) Back");
        Console.Write("Enter the number of the option then press enter: ");

        input = Console.ReadLine();
        Console.Clear();

        switch (input)
        {
            case("1"):
                // show currently loaded Neural Networks letting the user specify which one to export

                // Let the user specify the name of the file that every the network data will be exported to
                // savedNeuralNetwork[0] = true;
                break;

            case("2"):
                // show the currently loaded Language Networks letting the user specify which one to export

                // Let the user specify the name of the file that the data will be exported to

            case("3"):
                break;
                
            default:
                Console.WriteLine("Invalid input");
                break;
        }
    }

    static void DispalyRunMenu()
    {
        Console.WriteLine("Running options: ");
        Console.WriteLine("   1) Train Neural Network");
        Console.WriteLine("   2) Use Neural Network");
        Console.WriteLine("   3) Back");
        Console.Write("Enter the number of the option then press enter: ");

        input = Console.ReadLine();
        Console.Clear();

        switch (input)
        {
            case("1"):
                // show currently loaded Neural Networks letting the user specify which one to train

                // show the currently loaded dataSets letting the user specify which one they would like use to for training

                // let the user specify how many iterations they would like to train for

                break;

            case("2"):
                // show the currently loaded Language Networks letting the user specify which one to run

                // Let the user specify the data that they would like to input into the network (specific to each network)

                // Provide the output of the network to the user

            case("3"):
                break;
                
            default:
                Console.WriteLine("Invalid input");
                break;
        }
    }

    static void DisplayCreateMenu()
    {
        Console.WriteLine("Creation options: ");
        Console.WriteLine("   1) Classification Neural Network");
        Console.WriteLine("   2) Language Neural Network");
        Console.WriteLine("   3) Image Neural Network");
        Console.WriteLine("   4) Music Neural Network");
        Console.WriteLine("   5) Back");
        Console.Write("Enter the number of the option then press enter: ");

        input = Console.ReadLine();
        Console.Clear();

        switch (input)
        {
            case("1"):
                // Ask the user for a name of the Network

                // Ask the user for how many different dimentions network should support inputs

                // Ask the user for the differnet types of outputs the network should support

                // Repeatedly ask the user for dimentions of the hidden layers they want the network to have.

                // create a new classification neural Network

                break;

            case("2"):
                // Ask the user for a name of the Network

                // Ask the user if they have a vocabulary Embbeding they already trained

                // Ask the user for size of the context window they want to the network to support

                // Repeatedly ask the user for dimentions of the hidden layers they want the network to have.

                // create a new Language neural Network
                break;

            case("3"):
                // Ask the user for a name of the Network

                // Ask the user for the image dimentions they want to support

                // Ask the user for the color depth they want to support

                // Repeatedly ask the user for dimentions of the hidden layers they want the network to have.

                // create a new ImageDiffusion neural Network
                break;

            case("4"):
                // Ask the user for a name of the Network

                // Ask the user for the time resolution they want to support

                // Ask the user for the tone resolution they want to support (octaves)

                // Repeatedly ask the user for dimentions of the hidden layers they want the network to have.

                // create a new MusicDiffusion neural Network
                break;

            case("5"):
                break;
                
            default:
                Console.WriteLine("Invalid input");
                break;
        }
    }
}