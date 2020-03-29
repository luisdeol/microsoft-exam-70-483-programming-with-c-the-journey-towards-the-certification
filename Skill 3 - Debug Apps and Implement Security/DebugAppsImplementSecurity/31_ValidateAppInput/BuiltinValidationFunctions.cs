using System;

namespace _31_ValidateAppInput
{
    public static class BuiltinValidationFunctions
    {
        public static void GetExamples()
        {
            const string decimalString = "10,4";
            const string intString = "50";
            const string invalidIntString = "FIVE";

            // Valid conversions
            var decimalValid = decimal.Parse(decimalString);

            Console.WriteLine($"Conversion succesfully performed with decimal.Parse for {decimalValid}.");

            if (int.TryParse(intString, out int intSTryParse))
            {
                Console.WriteLine("Conversion succesfully performed with int.TryParse.");
            }
            else
            {
                Console.WriteLine("Conversion failed when performed using int.TryParse.");
            }

            var intConvert = Convert.ToInt32(intString);

            Console.WriteLine($"Conversion succesfully performed with int.Parse for {intConvert}.");

            // Invalid conversions
            try
            {
                var invalidInt = int.Parse(invalidIntString);
            }
            catch (FormatException)
            {
                Console.WriteLine($"int.Parse failed for {invalidIntString}");
            }

            if (!int.TryParse(invalidIntString, out int intTryParse))
            {
                Console.WriteLine($"int.TryParse returned false for {invalidIntString}");
            }

            try
            {
                var intConvertInvalid = Convert.ToInt32(invalidIntString);
            }
            catch (FormatException)
            {
                Console.WriteLine($"Convert.ToInt32 failed for {invalidIntString}");
            }

            Console.ReadLine();
        }
    }
}
