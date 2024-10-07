namespace KeypadPhoneConverter.KeypadPhoneConverter
{
    public static class KeypadMapper
    {
        private static readonly Dictionary<char, string> letterMappings = new()
        {
            { '1', "&’(" },
            { '2', "ABC" },
            { '3', "DEF" },
            { '4', "GHI" },
            { '5', "JKL" },
            { '6', "MNO" },
            { '7', "PQRS" },
            { '8', "TUV" },
            { '9', "WXYZ" }
        };

        public static char GetKey(char letter)
        {
            foreach (var letterMapping in letterMappings)
            {
                if (letterMapping.Value.Contains(letter))
                {
                    return letterMapping.Key;
                }
            }

            throw new ArgumentException($"Letter {letter} is not in the mapping list of the keypad.");
        }

        public static char GetFirstLetter(char key)
        {
            if (letterMappings.TryGetValue(key, out var letters))
            {
                return letters[0];
            }

            throw new ArgumentException($"Key {key} is not valid.");
        }

        public static char GetNextLetter(char key, char currentLetter)
        {
            if (!letterMappings.TryGetValue(key, out var letters))
            {
                throw new ArgumentException($"Key {key} is not valid.");
            }

            var currentIndex = letters.IndexOf(currentLetter);

            if (currentIndex == -1)
            {
                throw new ArgumentException($"Current letter {currentLetter} is not in the mapping list of the key {key}.");
            }

            var nextIndex = (currentIndex + 1) % letters.Length;

            return letters[nextIndex];
        }
    }
}
