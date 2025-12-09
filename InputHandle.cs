using System;

namespace SafeInputLibrary
{
    public static class SafeInput
    {




        public static void print(object value)
        {
            if (value == null)
                Console.WriteLine("null");
            else
                Console.WriteLine(value);
        }








        public static byte GetByte(string message = "Input")
        {
            while (true)
            {
                Console.Write(message + " : ");
                if (byte.TryParse(Console.ReadLine(), out byte num))
                    return num;
                Console.WriteLine("Invalid input. Please enter a valid byte (0-255).");
            }
        }

        public static sbyte GetSByte(string message = "Input")
        {
            while (true)
            {
                Console.Write(message + " : ");
                if (sbyte.TryParse(Console.ReadLine(), out sbyte num))
                    return num;
                Console.WriteLine("Invalid input. Please enter a valid sbyte (-128 to 127).");
            }
        }

        public static short GetShort(string message = "Input")
        {
            while (true)
            {
                Console.Write(message + " : ");
                if (short.TryParse(Console.ReadLine(), out short num))
                    return num;
                Console.WriteLine("Invalid input. Please enter a valid short (-32768 to 32767).");
            }
        }

        public static ushort GetUShort(string message = "Input")
        {
            while (true)
            {
                Console.Write(message + " : ");
                if (ushort.TryParse(Console.ReadLine(), out ushort num))
                    return num;
                Console.WriteLine("Invalid input. Please enter a valid ushort (0-65535).");
            }
        }

        public static int GetInt(string message = "Input")
        {
            while (true)
            {
                Console.Write(message + " : ");
                if (int.TryParse(Console.ReadLine(), out int num))
                    return num;
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }

        public static uint GetUInt(string message = "Input")
        {
            while (true)
            {
                Console.Write(message + " : ");
                if (uint.TryParse(Console.ReadLine(), out uint num))
                    return num;
                Console.WriteLine("Invalid input. Please enter a valid unsigned integer.");
            }
        }

        public static long GetLong(string message = "Input")
        {
            while (true)
            {
                Console.Write(message + " : ");
                if (long.TryParse(Console.ReadLine(), out long num))
                    return num;
                Console.WriteLine("Invalid input. Please enter a valid long integer.");
            }
        }

        public static ulong GetULong(string message = "Input")
        {
            while (true)
            {
                Console.Write(message + " : ");
                if (ulong.TryParse(Console.ReadLine(), out ulong num))
                    return num;
                Console.WriteLine("Invalid input. Please enter a valid unsigned long integer.");
            }
        }

        public static float GetFloat(string message = "Input")
        {
            while (true)
            {
                Console.Write(message + " : ");
                if (float.TryParse(Console.ReadLine(), out float num))
                    return num;
                Console.WriteLine("Invalid input. Please enter a valid float.");
            }
        }

        public static double GetDouble(string message = "Input")
        {
            while (true)
            {
                Console.Write(message + " : ");
                if (double.TryParse(Console.ReadLine(), out double num))
                    return num;
                Console.WriteLine("Invalid input. Please enter a valid double.");
            }
        }

        public static decimal GetDecimal(string message = "Input")
        {
            while (true)
            {
                Console.Write(message + " : ");
                if (decimal.TryParse(Console.ReadLine(), out decimal num))
                    return num;
                Console.WriteLine("Invalid input. Please enter a valid decimal.");
            }
        }

        public static bool GetBool(string message = "Input (true/false)")
        {
            while (true)
            {
                Console.Write(message + " : ");
                if (bool.TryParse(Console.ReadLine(), out bool result))
                    return result;
                Console.WriteLine("Invalid input. Please enter true or false.");
            }
        }

        public static char GetChar(string message = "Input a single character")
        {
            while (true)
            {
                Console.Write(message + " : ");
                if (char.TryParse(Console.ReadLine(), out char c))
                    return c;
                Console.WriteLine("Invalid input. Please enter a single character.");
            }
        }

        public static DateTime GetDateTime(string message = "Input date/time")
        {
            while (true)
            {
                Console.Write(message + " : ");
                if (DateTime.TryParse(Console.ReadLine(), out DateTime dt))
                    return dt;
                Console.WriteLine("Invalid input. Please enter a valid date/time.");
            }
        }
    }
}
