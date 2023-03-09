﻿namespace QualityAssurance2.CMD.Menu.Controlers.ConsoleControllers
{
    public static class ConsoleHelper
    {
        public static string GetStringFromConsole(string fieldName)
        {
            Console.WriteLine($"Please enter {fieldName}");
            string value = Console.ReadLine();
            if (value == " " || value == "") throw new Exception();

            return value;
        }

        public static int GetIntFromConsole(string fieldName)
        {
            string value = GetStringFromConsole(fieldName);
            return int.Parse(value);
        }

        public static DateTime GetDateTimeFromConsole(string fieldName)
        {
            string value = GetStringFromConsole(fieldName);
            return DateTime
                .ParseExact(value, ConsoleConstants.DateTimePattern, null);
        }
        public static float GetFloatFromConsole(string fieldName)
        {
            string value = GetStringFromConsole(fieldName);
            return float.Parse(value);
        }
    }
}
