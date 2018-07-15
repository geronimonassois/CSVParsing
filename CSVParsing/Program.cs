using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVParsing
{
    class Program
    {
        string datasource = Properties.Settings.Default.Data;

        static void Main(string[] args)
        {
            CSVParser.Parser();
        }
    }
}
