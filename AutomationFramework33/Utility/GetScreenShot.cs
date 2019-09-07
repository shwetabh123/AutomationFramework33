


using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;

using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AutomationFramework33.AutomationFramework33.Utility
{



    public class GetScreenShot
        {

           public static string Capture(IWebDriver driver,string screenshotname)
            {

            DateTime aDate = DateTime.Now;

            //string friendlyDatetime = string.Format("{0:yyyy-MM-dd_hh-mm-ss-tt}", DateTime.Now);
            //screenshot.SaveAsFile(@"D:\SeleniumTutorials\ScreenShotAT" + friendlyDatetime + ".png", System.Drawing.Imaging.ImageFormat.Png);

            //screenshot.SaveAsFile(@"D:\SeleniumTutorials\ScreenShotAT" + DateTime.Now.ToString("dd-MMM-yyyy") + ".png", System.Drawing.Imaging.ImageFormat.Png);
            

                        ITakesScreenshot ts = (ITakesScreenshot)driver;
                Screenshot screenshot = ts.GetScreenshot();
                string pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
                string finalpth = pth.Substring(0, pth.LastIndexOf("bin")) + "ErrorScreenshots\\" + screenshotname+ string.Format("{0:yyyy-MM-dd_hh-mm-ss-tt}", DateTime.Now) + ".png";
                string localpath = new Uri(finalpth).LocalPath;
                screenshot.SaveAsFile(localpath, OpenQA.Selenium.ScreenshotImageFormat.Png);
                return localpath;
            }
        }
    }
