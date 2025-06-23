namespace ExtractingStringPartsTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string country = "United States of America";
            string state = "California";
            string city = "San Fransicso";
            string landmark = "Alcatraz Island";
            // Output the length of state
            Console.WriteLine(state.Length);

            // Concatenate the contents of city and landmark * don't forget to add a space
            Console.WriteLine(city + " " + landmark);

            // Output the first character of country
            Console.WriteLine(country[0]);

            // Output a concatenation of the first and last characters of city
            Console.WriteLine(city[0].ToString() + city[city.Length - 1]);

            // Output the substring of landmark starting at 'c' and outputting to the end
            int indexC = landmark.IndexOf('c');
            if (indexC != -1)
            {
                Console.WriteLine(landmark.Substring(indexC));
            }

            // Output the substring of country starting at the first 'S' and ending at the first 'A'
            int indexS = country.IndexOf('S');
            int indexA = country.IndexOf('A', indexS + 1); // First 'A' after 'S'
            if (indexS != -1 && indexA != -1 && indexA > indexS)
            {
                Console.WriteLine(country.Substring(indexS, indexA - indexS + 1));
            }

            // Output the position of 'f' in California
            int indexF = state.IndexOf('f');
            Console.WriteLine(indexF);

            //************CHALLENGE****************//
            // Output how many vowels are in each of the strings in the format
            // California has n vowels




            // Show your evidence of the program running in the Readme file
        }
    }
}
