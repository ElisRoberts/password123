using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.DataView;
using Microsoft.ML;
using Microsoft.ML.Data;

namespace MLSEC203
{
    public class Passwords
    {
        [LoadColumn(0)]
        public string password;

        [LoadColumn(1)]
        public float letters;

        [LoadColumn(2)]
        public float capitals;

        [LoadColumn(3)]
        public float numbers;

        [LoadColumn(4)]
        public float puntuation;

        [LoadColumn(5)]
        public string label;
    }

    public class passwordPrediction
    {
        [ColumnName("PredictedLabel")]
        public string PredictedLabel;
    }

    public class Model
    {
        static void Main(string[] args)
        {
            var mlContext = new MLContext();

            IDataView dataView = mlContext.Data.LoadFromTextFile<Passwords>(path: "SEC203MLPassword.txt", hasHeader: false, separatorChar: ',');
            Console.WriteLine("Success");


            var pipeline = mlContext.Transforms.Conversion.MapValueToKey("label")
                .Append(mlContext.Transforms.Categorical.OneHotEncoding(outputColumnName: "passwordEncoded", inputColumnName: "password"))
                .Append(mlContext.Transforms.Concatenate("passwordEncoded", "letters", "capitals", "numbers", "puntuation"))
                .AppendCacheCheckpoint(mlContext)
                .Append(mlContext.MulticlassClassification.Trainers.StochasticDualCoordinateAscent(labelColumnName: "label", featureColumnName: "passwordEncoded"))
                .Append(mlContext.Transforms.Conversion.MapKeyToValue("PredictedLabel"));

            var model = pipeline.Fit(dataView);
            var analysis = model.CreatePredictionEngine<Passwords, passwordPrediction>(mlContext).Predict(
                new Passwords()
                {
                    letters = 5f,
                    capitals = 0f,
                    numbers = 0f,
                    puntuation = 0f,

                });
            Console.WriteLine($"Predicted strength is:{analysis.PredictedLabel}");

            Console.WriteLine("Press any key to exit....");
            Console.ReadLine();

        }
        

    }
}
