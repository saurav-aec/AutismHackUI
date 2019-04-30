using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutismHackScenario3.Models
{
    public class ScoreModelResponse
    {
        public string MeanScore { get; set; }
        public string ScoreStdDeviation { get; set; }
    }
    public class Rootobject
    {
        public Results Results { get; set; }
    }

    public class Results
    {
        public Output1 output1 { get; set; }
    }

    public class Output1
    {
        public string type { get; set; }
        public Value value { get; set; }
    }

    public class Value
    {
        public string[] ColumnNames { get; set; }
        public string[] ColumnTypes { get; set; }
        public string[][] Values { get; set; }
    }

}