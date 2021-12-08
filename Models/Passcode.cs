using System;
using System.ComponentModel.DataAnnotations;

namespace Random_Passcode_Generator
{
    public class Passcode
    {
        public string CreateRandomString()
        {
            Random rnd = new Random();
            string RandomString = "";
            const string alphanumericCharacters =
            "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            for (int i=0;i<=11;i++)
            {
                int num = rnd.Next(0,alphanumericCharacters.Length);
                char nextChar = alphanumericCharacters[num];
                RandomString = RandomString + nextChar.ToString();
            }
            System.Console.WriteLine(RandomString);
            return RandomString;
        }
        public Passcode()
        {
        }
    }
}