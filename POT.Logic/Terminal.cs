using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace POT.Logic
{
    public class Terminal
    {
        public static string ReadString(string texto)
        {
            string value;
            do
            {
                Console.Write(texto);
                value = Console.ReadLine();
                if (value == "")
                {
                    Console.WriteLine("Error: Nothing was inserted.");
                }
            } while (value == "");
            return value;
        }

        public static char ReadChar(string texto)
        {
            string value;
            do
            {
                value = ReadString(texto);
                if (value.Length > 1)
                {
                    Console.WriteLine("Error: Only one character can be inserted.");
                }
            } while (value.Length > 1);
            return Convert.ToChar(value);
        }

        public static int ReadInteger(string texto)
        {
            Regex regex = new Regex("^[0-9]*$");
            string value;
            do
            {
                value = ReadString(texto);
                if (!regex.IsMatch(value))
                {
                    Console.WriteLine("Error: Only numbers with no decimal part can be inserted.");
                }
            } while (!regex.IsMatch(value));
            return Convert.ToInt32(value);
        }

        public static float ReadFloat(string texto)
        {
            Regex regex = new Regex("^[0-9]*(\\.[0-9]{1,3})?$");
            string value;
            do
            {
                value = ReadString(texto);
                if (!regex.IsMatch(value))
                {
                    Console.WriteLine("Error: Invalid characters or pattern. Please follow this pattern: units.decimal");
                    Console.WriteLine("Units part can have any quantity of digits, decimal part is optional and can have between 1 and 3 digits");
                }
            } while (!regex.IsMatch(value));
            return Convert.ToSingle(value);
        }
    }
}
