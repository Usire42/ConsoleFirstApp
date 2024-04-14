namespace ConsoleFirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Ahoj, jak se jmenuješ ? ");
            //string nameinput = Console.ReadLine(); // Input your name

            //Console.WriteLine("Jaky jsi?");
            //string attributeinput = Console.ReadLine(); //input your  attribute

            //Console.WriteLine(nameinput + " je " + attributeinput); //output of your name anf attribute

            /*
            Console.WriteLine("Zadej číslo k umocnění: ");
            int inputnumber = int.Parse(Console.ReadLine());    //input number to square
            int squareout = (int)Math.Pow(inputnumber, 2);      // square the number
            Console.WriteLine("Vysledek: " + squareout);        //print result

            Console.WriteLine("Zadej poloměr kruhu (cm): ");

            float inputradius = float.Parse(Console.ReadLine());        //input radius of the circle

            float circresult = (float)(2 * Math.PI * inputradius);      //calculate circumference of a circle
            float contresult = (float)(Math.PI * Math.Pow(inputradius, 2)); //calculate content of the circle

            Console.WriteLine($"Obvod zadaného kruhu je: {circresult}");    //print calculated circumference of a circle
            Console.WriteLine($"Jeho obsah je: {contresult} cm^2");         //print calculated content of the circle

            Console.WriteLine("Vítejte v kalkulačce");

            

            // insert message for encryption
            string message = "Test Zpravy".ToLower();
            Console.WriteLine($" Original message: {message}");
            string CodedMessage = "";
            // Encryption shift
            int shift = 5;

            //for loop for encryption
            foreach (char c in message)
            {
                int i = (int)c;
                if (i == 32)
                {
                    CodedMessage += (char)i;
                }
                else
                {
                    int encrypt = ((i - 96 + shift) % 26) + 96;
                    CodedMessage += (char)encrypt;
                }

            }
            Console.WriteLine(CodedMessage);
            */

            // řetězec, který chceme dekódovat
            string codedString = ".-../. --- -./.-/.-./-../---//.-";
            string plaintext = "zde je normanli text";
            //Console.WriteLine("Původní zpráva: {0}", codedString);
            // řetězec s dekódovanou zprávou
            string zprava = "";

            // vzorová pole
            char[] separators = new char[] { '/', '/' };
            string abecedniZnaky = "abcdefghijklmnopqrstuvwxyz";
            string[] morseovyZnaky = {".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....",
            "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-",
            "...-", ".--", "-..-", "-.--", "--.."};

            // Create Dictionary of Morse alph
            var MorseDict = new Dictionary<string, string>();
 
            
            for (int i = 0; i < morseovyZnaky.Length; i++) {
                MorseDict.Add(abecedniZnaky[i].ToString(), morseovyZnaky[i]);
            };

            MorseDict.Add(" ".ToString(), "/".ToString());
            var symbols = ( ".", ",", "?", "!" );
            MorseDict.Add(symbols.ToString(), "//");


        }
    }
}
