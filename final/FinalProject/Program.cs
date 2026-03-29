using System;
using System.Data;
using NeuralNetwork;
using NeuralNetwork.DataSet;
using NeuralNetwork.LittleLanguageModel;
using NeuralNetwork.LittleLanguageModel.AIContext;

class Program
{
    static bool isRunning = true;
    static string input;
    static List<string> modelNames = new List<string>{"Classification", "Language", "ImageDiffusion"," MusicDiffusion"};
    static List<string> dataSetTypes = new List<string>{"Classification", "Speech", "Vocabulary", "Image", "Music"};

    static void Main(string[] args)
    {
        List<DataSet> loadedDataSets = new List<DataSet>();
        List<NeuralNet> loadedNeuralNetworks = new List<NeuralNet>();

        Console.WriteLine("Welcome.");
        while (isRunning)
        {
            Menu();
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
        Console.WriteLine("Enter the number of the option then press enter: ");

        input = Console.ReadLine();

        switch (input)
        {
            case("1"):
                DispalyImportMenu();
                break;
            case("2"):
                DispalyExportMenu();
                break;
            case("3"):
                DispalyRunMenu();
                break;
            case("4"):
                DisplayCreateMenu();
                break;
            case("5"):

                // do a quick check of unsaved content and alert the user if any found

                //get confirmation from the user

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
        Console.WriteLine("Enter the number of the option then press enter: ");

        input = Console.ReadLine();

        switch (input)
        {
            case("1"):
                Console.Write("(");
                foreach(string name in modelNames){Console.Write(name);}
                Console.WriteLine(")");

                Console.Write("Enter Model Name: ");
                string modelToImport = Console.ReadLine();

                if (modelNames.Contains(modelToImport))
                {
                    Console.Write("Enter File Path: ");
                    string filePath = Console.ReadLine();
                    // System would then import model report on status and return to main menu
                }
                else
                {
                    Console.WriteLine("Invalid Model Name");
                }
                break;

            case("2"):
                Console.Write("(");
                foreach(string type in dataSetTypes){Console.Write(type);}
                Console.WriteLine(")");

                Console.Write("Enter DataSet Type: ");
                string dataSetType = Console.ReadLine();

                if (dataSetTypes.Contains(dataSetType))
                {
                    Console.Write("Enter File Path: ");
                    string filePath = Console.ReadLine();
                    // System would then import dataSet report on status and return to main menu
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
        Console.WriteLine("Enter the number of the option then press enter: ");

        input = Console.ReadLine();

        switch (input)
        {
            case("1"):
                // show currently loaded Neural Networks letting the user specify which one to export

                // Let the user specify the name of the file that every the network data will be exported to

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
        Console.WriteLine("Enter the number of the option then press enter: ");

        input = Console.ReadLine();

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
        Console.WriteLine("Enter the number of the option then press enter: ");

        input = Console.ReadLine();

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