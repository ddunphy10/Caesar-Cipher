using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            Console.WriteLine("Please enter the message you would like to encrypt: ");
            string message = Console.ReadLine();
            message.ToLower();

            char[] secretMessage = message.ToCharArray();
            int secretMessageSize = secretMessage.Length;

            char[] encryptedMessage = new char[secretMessageSize];

            for(int i = 0; i < secretMessageSize; i++)
            {
                char letter = secretMessage[i];
                int letterIndex = Array.IndexOf(alphabet, letter);
                int letterIndexPlusThree = (letterIndex + 3) % alphabet.Length;
                char encryptedChar = alphabet[letterIndexPlusThree];

                encryptedMessage[i] = encryptedChar;
            }

            Console.WriteLine(String.Join("", encryptedMessage));
        }
    }
}