using KeypadPhoneConverter.Infrastructure.Interfaces;
using KeypadPhoneConverter.Service.Utilities;

namespace KeypadPhoneConverter.Service.Services
{
    public class KeypadService : IKeypadService
    {
        #region [Public]

        public string ConvertToText(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return string.Empty;
            }

            var text = string.Empty;
            char lastKeyLetter = '\0';

            foreach (var currentKey in input)
            {
                if (currentKey == '#')
                {
                    return text;
                }

                if (currentKey == '*')
                {
                    text = RemoveLastLetterFrom(text);
                    lastKeyLetter = '\0';
                    continue;
                }

                if (currentKey == ' ')
                {
                    lastKeyLetter = '\0';
                    continue;
                }

                (text, lastKeyLetter) = CombineKeyToText(currentKey, text, lastKeyLetter);
            }

            return text;
        }

        #endregion

        #region [Private]

        private static (string, char) CombineKeyToText(char currentKey, string text, char lastKeyLetter)
        {
            if (lastKeyLetter == '\0' || currentKey != KeypadMapper.GetKey(lastKeyLetter))
            {
                lastKeyLetter = KeypadMapper.GetFirstLetter(currentKey);
                text += lastKeyLetter;
            }
            else
            {
                lastKeyLetter = KeypadMapper.GetNextLetter(currentKey, lastKeyLetter);
                text = lastKeyLetter == KeypadMapper.GetFirstLetter(currentKey)
                       ? text + lastKeyLetter
                       : RemoveLastLetterFrom(text) + lastKeyLetter;
            }

            return (text, lastKeyLetter);
        }

        private static string RemoveLastLetterFrom(string text)
        {
            if (text != null && text.Length > 0)
            {
                text = text.Substring(0, text.Length - 1);
            }

            return text ?? string.Empty;
        }

        #endregion
    }
}
