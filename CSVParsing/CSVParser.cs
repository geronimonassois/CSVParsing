using System;
using System.Collections.Generic;
using System.Windows;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace CSVParsing
{
    class CSVParser
    {
        private static List<SalesData> salesDataList = new List<SalesData>();

        public static void Parser()
        {
            try
            {
                using (StreamReader reader = new StreamReader(Properties.Settings.Default.Data))
                {
                    string FileContent = reader.ReadToEnd();

                    StringReader stringReader = new StringReader(FileContent);

                    stringReader.ReadLine();

                    string helpline = "";
                    string[] helparr = null;


                    while (stringReader.Peek() >= 0)
                    {
                        helpline = stringReader.ReadLine();
                        helparr = helpline.Split(',');

                        SalesData salesData = new SalesData(helparr[0], helparr[1], helparr[3], helparr[7], helparr[8], Int32.Parse(helparr[2]), Int32.Parse(helparr[6]), Int32.Parse(helparr[9]), short.Parse(helparr[5]), Double.Parse(helparr[9]), Double.Parse(helparr[10]));

                        salesDataList.Add(salesData);
                    }

                    PrintList(salesDataList);
                    Console.ReadKey();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private static void PrintList(List<SalesData> list)
        {
       
            for(int i = 0; i < list.Count; i++)
            {
                list[i].PrintMetadata();
            }
        }

    }
}
