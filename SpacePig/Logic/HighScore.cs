using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;

namespace Huestel.SpacePig.Logic
{
    internal class HighScore
    {

        private string secretKey = "";
        // Edit this value and make sure it's the same as the one stored on the server

        public string AddScoreUrl = "";
        public string HighscoreUrl = "";

        // remember to use StartCoroutine when calling this function!
        public void PostScores(string name, int score)
        {
            try
            {
                //This connects to a server side php script that will add the name and score to a MySQL DB.
                // Supply it with a string representing the players name and the players score.
                string hash = CreateMd5Hash(name + score + secretKey).ToLower();

                string postUrl = AddScoreUrl + "name=" + name + "&score=" + score + "&hash=" + hash;

                // Post the URL to the site and create a download object to get the result.
                var request = (HttpWebRequest) WebRequest.Create(postUrl);
                request.GetResponse();
            }
            catch (Exception)
            {
                // ignored
            }
        }

        public List<string> GetHighScoreValues()
        {
            try
            {
                var wc = new WebClient();
                byte[] raw = wc.DownloadData(HighscoreUrl);
                string webData = Encoding.UTF8.GetString(raw);
                return webData.Split('\n').ToList();
            }
            catch (Exception)
            {
                // So be it
                return new List<string>();
            }
        }


        public string CreateMd5Hash(string input)
        {
            // Use input string to calculate MD5 hash
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(input);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            // Convert the byte array to hexadecimal string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
                // To force the hex string to lower-case letters instead of
                // upper-case, use he following line instead:
                // sb.Append(hashBytes[i].ToString("x2")); 
            }
            return sb.ToString();
        }
    }


}
