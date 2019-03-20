using System;


using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace MyCoffeeProject
{
    class PasswordHasher
    {
        private const int SaltByteSize = 24;
        private const int HashByteSize = 20; // to match the size of the PBKDF2-HMAC-SHA-1 hash 
        private const int Pbkdf2Iterations = 10000;
        private const int IterationIndex = 0;
        private const int SaltIndex = 1;
        private const int Pbkdf2Index = 2;
        
        public static string HashPassword(string password)
        {
            //Takes a string and returns a PBKDF2 hash string with the format [# of iterations]:[Salt Used]:[Resulting Hash]
            var cryptoProvider = new RNGCryptoServiceProvider();
            var salt = new byte[SaltByteSize];
            cryptoProvider.GetBytes(salt);

            var hash = GetPbkdf2Bytes(password, salt, Pbkdf2Iterations, HashByteSize);
            return Pbkdf2Iterations.ToString("X") + ":" +
                   Convert.ToBase64String(salt) + ":" +
                   Convert.ToBase64String(hash);
        }

        public static bool ValidatePassword(string password, string correctHash)
        {
            char[] delimiter = { ':' };
            var split = correctHash.Split(delimiter);
            var iterations = Convert.ToInt32(split[IterationIndex], 16);
            var salt = Convert.FromBase64String(split[SaltIndex]);
            var hash = Convert.FromBase64String(split[Pbkdf2Index]);

            var testHash = GetPbkdf2Bytes(password, salt, iterations, hash.Length);
            return SlowEquals(hash, testHash);
        }

        private static bool SlowEquals(IReadOnlyList<byte> firstByteHash, IReadOnlyList<byte> secondByteHash)
        {
            var diff = (uint)firstByteHash.Count ^ (uint)secondByteHash.Count;
            for (var i = 0; i < firstByteHash.Count && i < secondByteHash.Count; i++)
            {
                diff |= (uint)(firstByteHash[i] ^ secondByteHash[i]);
            }
            return diff == 0;
        }

        private static byte[] GetPbkdf2Bytes(string password, byte[] salt, int iterations, int outputBytes)
        {
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt) {IterationCount = iterations};
            return pbkdf2.GetBytes(outputBytes);
        }
    }
}
