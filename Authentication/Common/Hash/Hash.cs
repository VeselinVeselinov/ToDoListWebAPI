using System;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;

namespace ToDoListWebAPI.Authentication.Common.Hash
{
    public static class Hash
    {
        public static string Compute(string value, byte[] salt)
        {
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2
                (password : value, 
                salt : salt, 
                prf : KeyDerivationPrf.HMACSHA512, 
                iterationCount : 10000, 
                numBytesRequested : 256/8 ));

            return hashed;
        }
    }
}
