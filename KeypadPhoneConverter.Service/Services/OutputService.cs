using KeypadPhoneConverter.Infrastructure.Interfaces;

namespace KeypadPhoneConverter.Service.Services
{
    public class OutputService : IOutputService
    {
        public void DisplayKeypadOutput(string input, string output)
        {
            Console.WriteLine($"Input ({input ?? string.Empty}) on the keypad gives => Output ({output ?? string.Empty}).");
        }
    }
}
