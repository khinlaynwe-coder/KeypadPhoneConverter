using KeypadPhoneConverter.Infrastructure.Interfaces;
using System.Text.RegularExpressions;

namespace KeypadPhoneConverter.Service.Services
{
    public class InputService : IInputService
    {
        public string GetKeypadInput()
        {
            while (true)
            {
                Console.Write("Enter keypad phone input or type N to exit: ");
                var input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Input cannot be empty.");
                    continue;
                }

                input = input.Trim();

                if (input.Equals("N", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Exiting......");
                    return string.Empty;
                }

                if (!Regex.IsMatch(input, @"^[1-9* ]+#$"))
                {
                    Console.WriteLine("Input can only contain numbers 1-9, special character *, and spaces. Input also must end with #.");
                    continue;
                }

                return input;
            }
        }
    }
}
