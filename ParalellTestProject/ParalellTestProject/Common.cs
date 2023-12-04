using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ParalellTestProject
{
    internal class Common
    {
        string driverLocation = @"c:\webdrivers";
        IWebDriver driver;
        private Dictionary<string, string> properties = new Dictionary<string, string>
        {
            { "google", "https://google.com" },
            { "youtube", "https://youtube.com" },
            { "cabrajeta", "https://cabrajeta.com" },
            { "x", "https://x.com" },
            { "facebook", "https://facebook.com" },
        };

        public Common() 
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("--start-maximized");
            driver = new ChromeDriver(driverLocation, chromeOptions);
        }

        private bool GoSomewhere(string str)
        {
            driver.Navigate().GoToUrl(properties[str]);
            Thread.Sleep(new Random().Next(2, 6) * 1000);
            var title = driver.Title.ToLower();
            driver.Close();
            driver.Quit();
            return title.ToLower().Contains(str);
        }

        public bool GoToGoogle()
        {
            return GoSomewhere("google");
        }

        public bool GoToYouTube()
        {
            return GoSomewhere("youtube");
        }

        public bool GoToCabrajeta()
        {
            return GoSomewhere("cabrajeta");
        }

        public bool GoToTwitter()
        {
            return GoSomewhere("twitter");
        }

        public bool GoToFacebook()
        {
            return GoSomewhere("facebook");
        }

    }
}
