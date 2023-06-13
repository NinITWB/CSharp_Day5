using System.IO;
using System.Text;

namespace Task1
{
    class Program
    {
        const string fileName = "CountryList.csv";
        static void Main(string [] args)
        {
            IList<string> listOfCountry = new List<string>();
            ReadFile(ref listOfCountry);

            foreach (var i in listOfCountry)
            {
                Console.WriteLine(i);
            }
        }

        static void ReadFile(ref IList<string> countryList)
        {
            StreamReader sRead;
            try
            {
                sRead = new StreamReader(fileName);
                string line;
                while ((line = sRead.ReadLine()!) != null)
                {
                    string[] fetchData = line.Split(',', 6, StringSplitOptions.RemoveEmptyEntries);
                    countryList.Add(fetchData[5]);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            
        }


        /*static async Task ReadFile()
        {
            Char[] buffet;
            using (var sr = new StreamReader(fileName))
            {
                buffet = new Char[(int)sr.BaseStream.Length];
                await sr.ReadAsync(buffet, 0, (int)sr.BaseStream.Length);

                Console.WriteLine(new String(buffet));
            }
        }*/
    }
}
