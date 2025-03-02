using Microsoft.AspNetCore.Mvc;
using System;

namespace FisherYatesWebApp
{
    public class FisherYates : Controller
    {
        [HttpGet("fisheryates")]
        public ActionResult Index(string input)
        {
            var shuffledResult = Shuffle(input);
            return Content(shuffledResult, "text/plain");
        }

        public string Shuffle(string input)
        {
            var elements = input.Split('-');
            var random = new Random();

            for (int i = elements.Length - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);

                var temp = elements[i];
                elements[i] = elements[j];
                elements[j] = temp;
            }
            return string.Join('-', elements);
        }
    }
}
