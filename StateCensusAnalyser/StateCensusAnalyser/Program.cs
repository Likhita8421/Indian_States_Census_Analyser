using System;

namespace StateCensusAnalyser
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string filePath = @"C:\Users\hp\Documents\Repository\Indian_States_Census_Analyser\StateCensusAnalyser\StateCensusAnalyser\StateCensusData.csv";
            Stateanalyser value = new Stateanalyser();
            value.AnalyseData(filePath);
            string fileofPath = @"C:\Users\hp\Documents\Repository\Indian_States_Census_Analyser\StateCensusAnalyser\StateCensusAnalyser\StateCode.csv";
            value.StateCodeAnalyser(fileofPath);
        }
    }
}
