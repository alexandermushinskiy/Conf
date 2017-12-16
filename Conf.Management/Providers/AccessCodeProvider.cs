using System;
using Conf.Management.Extensibility.Providers;

namespace Conf.Management.Providers
{
    internal class AccessCodeProvider : IAccessCodeProvider
    {
        private static readonly Random Rand = new Random(DateTime.UtcNow.Millisecond);
        private static readonly char[] AllowableChars = "ABCDEFGHJKMNPQRSTUVWXYZ123456789".ToCharArray();

        public string Generate(int length = 5)
        {
            char[] result = new char[length];
            lock (Rand)
            {
                for (int i = 0; i < length; i++)
                {
                    result[i] = AllowableChars[Rand.Next(0, AllowableChars.Length)];
                }
            }

            return new string(result).ToUpper();
        }
    }
}