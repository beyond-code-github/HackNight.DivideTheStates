namespace HackNight.DivideTheStatesCSharp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using HackNight.DivideTheStates.Engine;

    class Program
    {
        static void Main(string[] args)
        {
            var states = new Dictionary<string, int>();
            states.Add(".Alabama", 4833722);
            states.Add(".Alaska", 735132);
            states.Add(".Arizona", 6626624);
            states.Add(".Arkansas", 2959373);
            states.Add(".California", 38332521);
            states.Add(".Colorado", 5268367);
            states.Add(".Connecticut", 3596080);
            states.Add(".Delaware", 925749);
            states.Add(".District of Columbia", 646449);
            states.Add(".Florida", 19552860);
            states.Add(".Georgia", 9992167);
            states.Add(".Hawaii", 1404054);
            states.Add(".Idaho", 1612136);
            states.Add(".Illinois", 12882135);
            states.Add(".Indiana", 6570902);
            states.Add(".Iowa", 3090416);
            states.Add(".Kansas", 2893957);
            states.Add(".Kentucky", 4395295);
            states.Add(".Louisiana", 4625470);
            states.Add(".Maine", 1328302);
            states.Add(".Maryland", 5928814);
            states.Add(".Massachusetts", 6692824);
            states.Add(".Michigan", 9895622);
            states.Add(".Minnesota", 5420380);
            states.Add(".Mississippi", 2991207);
            states.Add(".Missouri", 6044171);
            states.Add(".Montana", 1015165);
            states.Add(".Nebraska", 1868516);
            states.Add(".Nevada", 2790136);
            states.Add(".New Hampshire", 1323459);
            states.Add(".New Jersey", 8899339);
            states.Add(".New Mexico", 2085287);
            states.Add(".New York", 19651127);
            states.Add(".North Carolina", 9848060);
            states.Add(".North Dakota", 723393);
            states.Add(".Ohio", 11570808);
            states.Add(".Oklahoma", 3850568);
            states.Add(".Oregon", 3930065);
            states.Add(".Pennsylvania", 12773801);
            states.Add(".Rhode Island", 1051511);
            states.Add(".South Carolina", 4774839);
            states.Add(".South Dakota", 844877);
            states.Add(".Tennessee", 6495978);
            states.Add(".Texas", 26448193);
            states.Add(".Utah", 2900872);
            states.Add(".Vermont", 626630);
            states.Add(".Virginia", 8260405);
            states.Add(".Washington", 6971406);
            states.Add(".West Virginia", 1854304);
            states.Add(".Wisconsin", 5742713);
            states.Add(".Wyoming", 582658);
            states.Add("Puerto Rico", 3615086);

            var result = Engine.Divide(4, states.AsEnumerable().ToList(), o => o.Value);

            var totals = result.Select(o => (double)o.Value.Select(v => v.Value).Sum());
            var stdDev = StandardDeviation(totals);

            var s = "";

        }

        public static double StandardDeviation(IEnumerable<double> valueList)
        {
            double M = 0.0;
            double S = 0.0;
            int k = 1;
            foreach (double value in valueList)
            {
                double tmpM = M;
                M += (value - tmpM) / k;
                S += (value - tmpM) * (value - M);
                k++;
            }
            return Math.Sqrt(S / (k - 2));
        }
    }
}
