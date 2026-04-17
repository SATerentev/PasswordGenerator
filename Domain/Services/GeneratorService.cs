using PassGeneratorService.Application.Interfaces;
using PassGeneratorService.Domain.Entity;

namespace PassGeneratorService.Domain.Services
{
    public class GeneratorService : IGeneratorService
    {
        private Random _random = new Random();

        public Password GeneratePass(int passLength, bool includeUpperCase, bool includeNumbers, bool includeSymbols)
        {
            const string lowerCaseChars = "abcdefghijklmnopqrstuvwxyz";
            const string upperCaseChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string numberChars = "0123456789";
            const string symbolChars = "!@#$%^&*()_+-=[]{}|;:,.<>?";
            string chars = lowerCaseChars;
            string result = string.Empty;

            if (passLength <= 0) 
                throw new ArgumentException("Длина пароля не может быть отрицательной или равна нулю.");

            if (includeUpperCase) chars += upperCaseChars;
            if (includeNumbers) chars += numberChars;
            if (includeSymbols) chars += symbolChars;

            for (int i = 0; i < passLength; i++)
            {
                result += chars[_random.Next(chars.Length)];
            }

            return new Password(result);
        }
    }
}
