namespace BasicCSharpDel1
{
    internal class Program
    {   /* To hovedting inne i en klasse:
         *  Felt - tislvarer (nesten Javascript Globale variabler
         *  Metoder - tilsvarer funksjoner i javascript
         * 
         * Pensum idag:
         *  C# er et sterkt typet programmeringspråk
         *  Intro til Visual Studio
         *  Debugging
         *  Grunnskelett i en class
         *  Variabler, Tilordning og datatyper
         *      bool - boolean (true/false)
         *      int - heltall   
         *      float/ double - desimaltall
         *      string - tekst
         *  Valgsetninger
         *  Løkker - for og while som i Javascript - Foreach (for tabeller)
         *  Tabeller
         *  Metoder (funksjoner
         *  Input og output
         * 
         */

        static void Main(string[] args)

        {
            //Deklarere en variabel av hver av de nevnte datatypene
            bool b;
            int i;
            float f;
            double d;
            string s;

            // Tilordning
            b = true;
            i = 5;
            f = 3.2f;
            d = 1.2;
            s = "geagaegea";

            // Kan også deklarer og tilordne samtidig
            bool b2 = false;
            int i2 = 3;
            float f2 = 1.3f;
            double d2 = 7.7;
            string s2 = "test";

            var b3 = false;
            var i3 = 3;
            var f3 = 5.5f;
            var d3 = 9.9;
            var s3 = "dada";

        //    if (args.Length == 0) 
        //    { 
        //        Console.WriteLine("Hallo! Ingen parametre ");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Hallo! Ingen parametre " + args.Length);
        //    }
        //    for (var i = 0; i < args.Length; i++)
        //    {
        //        var parameterNo = i + 1;
        //        Console.WriteLine("Parameter " + parameterNo + ": " + args[i]);
        //    }
        //    foreach (var text in args)
        //    {
        //        Console.WriteLine("Parameter " + text);
        //    }
            
        }
    }
}