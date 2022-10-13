// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Tracing;
using System.Globalization;

namespace CaesarCipher
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a word to encrypt / decrypt");
            string s;
            s = Console.ReadLine();
            Console.WriteLine("Enter a number as the offset");
            int n;
            n = Convert.ToInt32(Console.ReadLine());

            decrypt(s,n);
        }
        public static void cipher(string word1,int offset)
        { 
            string encryption = null;
            int stringlength = word1.Length;

            foreach (char letter in word1)
            {
                char encrypted_char;
                int ascii_value = letter + offset;
                while (ascii_value > 122)
                {
                    ascii_value -= 26;
                }

                encrypted_char = (char)(ascii_value);
                encryption += encrypted_char;
            }
            Console.Write(encryption);
        }
        public static void decrypt(string word1, int offset)
        {
            string decryption = null;
            int stringlength = word1.Length;
            foreach (char letter in word1)
            {
                char decrypted_char;
                int ascii_value = letter - offset;
                while (ascii_value < 97)
                {
                    ascii_value += 26;
                }
                decrypted_char = (char)(ascii_value);
                decryption += decrypted_char;
            }
            Console.Write(decryption);
        }
    }
}
