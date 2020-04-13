using System.Security.Cryptography;

namespace ToDoListWebAPI.Authentication.Common.Hash
{
    public static class Salt
    {
        public static byte[] GenerateSalt()
        {
            byte[] bytes = new byte[128 / 8];

            using (var randomizer = RandomNumberGenerator.Create())
            {
                randomizer.GetBytes(bytes);
            }

            return bytes;
        }
    }
}
