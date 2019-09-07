
using AutomationFramework33.AutomationFramework33.BaseClass;
using AutomationFramework33.AutomationFramework33.Configuration;
using AutomationFramework33.AutomationFramework33.Settings;
using AutomationFramework33.AutomationFramework33.Utility;
using AventStack.ExtentReports;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;
using System.Threading;
using System.Xml;

namespace AutomationFramework33.AutomationFramework33.TestScripts
{

    [TestFixture]

    [Parallelizable]

    public class Testndtv : BaseClasses

    {


        ObjectRepository O = new ObjectRepository();



        public Testndtv() : base(BrowserType.Chrome)
        {






        }



        //  [ClassInitialize]

        public static  ExtentTest parentTest;

        public static ExtentTest childTest;


        public static ExtentTest childTestnew;




        //  public static ThreadLocal<ExtentTest> parentTest = new ThreadLocal<ExtentTest>();
        // public static ThreadLocal<ExtentTest> childTest = new ThreadLocal<ExtentTest>();

        // public static ThreadLocal<ExtentTest> childTestnew = new ThreadLocal<ExtentTest>();



        [SetUp]


        public void BeforeTest()

        {


            InitWebDriver(_browserType);

        }




  



        public  void InitWebDriver(BrowserType browsertype)

        {


            ObjectRepository.Config = new AppConfigReader();



            if (browsertype == BrowserType.Chrome)

                O.Driver = GetChromeDriver();


            else if (browsertype == BrowserType.IExplorer)


                O.Driver = GetIEDriver();


            else if (browsertype == BrowserType.Firefox)


                O.Driver = GetFirefoxDriver();




            //switch (ObjectRepository.Config.GetBrowser())
            //{
            //    case BrowserType.Firefox:
            //        ObjectRepository.Driver = GetFirefoxDriver();
            //        //  Logger.Info(" Using Firefox Driver  ");



            //        break;

            //    case BrowserType.Chrome:
            //        ObjectRepository.Driver = GetChromeDriver();
            //        //      Logger.Info(" Using Chrome Driver  ");


            //       break;

            //    case BrowserType.IExplorer:
            //        ObjectRepository.Driver = GetIEDriver();
            //        //    Logger.Info(" Using Internet Explorer Driver  ");


            //        break;



            //    default:
            //        throw new NoSuitableDriverFound("Driver Not Found : " + ObjectRepository.Config.GetBrowser().ToString());










            //}


            O.Driver.Manage()
                 .Timeouts().PageLoad = TimeSpan.FromSeconds(ObjectRepository.Config.GetPageLoadTimeOut());



            O.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(ObjectRepository.Config.GetElementLoadTimeOut());


            O.Driver.Manage().Window.Maximize();
            //BrowserHelper.BrowserMaximize();


            // creating tests

            //  ExtentTest tests = extent.createTest(method.getName());
            // parentTest.set(tests);

            //ExtentTest testclass = parentTest.get().createNode(getClass().getSimpleName());

            //childTest.set(testclass);


            //ExtentTest testmethod = childTest.get().createNode(method.getName());

            //childTestnew.set(testmethod);



            // creating nodes	
            //  parentTest = extent.CreateTest("MyFirstTest");



            parentTest = extent.CreateTest(TestContext.CurrentContext.Test.ClassName);

            childTest = parentTest.CreateNode(TestContext.CurrentContext.Test.MethodName);


            childTestnew = childTest.CreateNode(TestContext.CurrentContext.Test.Name);





        }





        [Test]

      
        public void Verifyndtv()
        {

            O.Driver.Navigate().GoToUrl("https://www.onlinesbi.com/");



            Thread.Sleep(19000);



            String title = O.Driver.Title;
            Console.WriteLine("Title of webpage is " + title);


            childTest.Log(Status.Info, "Title of webpage is " + title);

            childTest.AssignCategory("Regression");



            // childTest.(LogStatus.Info, "Title of webpage is " + title);



            //HomePage b = new HomePage();



            //string screenShotPath = GetScreenShot.Capture(O.Driver, "screesnshotname");

            //BaseClasses.test.Log(LogStatus.Info, "Snapshot below: " + BaseClasses.test.AddScreenCapture(screenShotPath));






            //b.clickonMarkets();


            //Thread.Sleep(8000);


            //string screenShotPath1 = GetScreenShot.Capture(O.Driver, "screesnshotname");

            //BaseClasses.test.Log(LogStatus.Info, "Snapshot below: " + BaseClasses.test.AddScreenCapture(screenShotPath1));


            //BaseClasses.test.Log(LogStatus.Info, "clickonMarkets");


            //O.Driver.Navigate().Back();

            ////  BasePage.SwitchToWindowWithTitle("Business News Live, Share Market News - Read Latest Finance News, IPO, Mutual Funds News", ObjectRepository.Driver);

            //Thread.Sleep(4000);


            //string screenShotPath2 = GetScreenShot.Capture(O.Driver, "screesnshotname");

            //BaseClasses.test.Log(LogStatus.Info, "Snapshot below: " + BaseClasses.test.AddScreenCapture(screenShotPath2));

            //BaseClasses.test.Log(LogStatus.Info, "Business News Live, Share Market News - Read Latest Finance News, IPO, Mutual Funds News");



            //b.clickonNews();

            //Thread.Sleep(8000);


            //string screenShotPath3 = GetScreenShot.Capture(O.Driver, "screesnshotname");

            //BaseClasses.test.Log(LogStatus.Info, "Snapshot below: " + BaseClasses.test.AddScreenCapture(screenShotPath3));

            //BaseClasses.test.Log(LogStatus.Info, "clickonNews");


            //O.Driver.Navigate().Back();

            ////  BasePage.SwitchToWindowWithTitle("Business News Live, Share Market News - Read Latest Finance News, IPO, Mutual Funds News", ObjectRepository.Driver);

            //Thread.Sleep(15000);

            //string screenShotPath4 = GetScreenShot.Capture(O.Driver, "screesnshotname");

            //BaseClasses.test.Log(LogStatus.Info, "Snapshot below: " + BaseClasses.test.AddScreenCapture(screenShotPath4));

            //BaseClasses.test.Log(LogStatus.Info, "Business News Live, Share Market News - Read Latest Finance News, IPO, Mutual Funds News");



            //b.clickonIndustry();

            //Thread.Sleep(8000);

            //string screenShotPath5 = GetScreenShot.Capture(O.Driver, "screesnshotname");

            //BaseClasses.test.Log(LogStatus.Info, "Snapshot below: " + BaseClasses.test.AddScreenCapture(screenShotPath5));


            //BaseClasses.test.Log(LogStatus.Info, "clickonIndustry");

            //O.Driver.Navigate().Back();


            ////  BasePage.SwitchToWindowWithTitle("Business News Live, Share Market News - Read Latest Finance News, IPO, Mutual Funds News", ObjectRepository.Driver);

            //Thread.Sleep(8000);

            //string screenShotPath6 = GetScreenShot.Capture(O.Driver, "screesnshotname");

            //BaseClasses.test.Log(LogStatus.Info, "Snapshot below: " + BaseClasses.test.AddScreenCapture(screenShotPath6));


            //BaseClasses.test.Log(LogStatus.Info, "Business News Live, Share Market News - Read Latest Finance News, IPO, Mutual Funds News");


            //b.clickonJobs();

            //Thread.Sleep(8000);

            //string screenShotPath7 = GetScreenShot.Capture(O.Driver, "screesnshotname");

            //BaseClasses.test.Log(LogStatus.Info, "Snapshot below: " + BaseClasses.test.AddScreenCapture(screenShotPath7));


            //BaseClasses.test.Log(LogStatus.Info, "clickonJobs");

            //O.Driver.Navigate().Back();


            ////   BasePage.SwitchToWindowWithTitle("Business News Live, Share Market News - Read Latest Finance News, IPO, Mutual Funds News", ObjectRepository.Driver);

            //Thread.Sleep(8000);

            //string screenShotPath8 = GetScreenShot.Capture(O.Driver, "screesnshotname");

            //BaseClasses.test.Log(LogStatus.Info, "Snapshot below: " + BaseClasses.test.AddScreenCapture(screenShotPath8));


            //BaseClasses.test.Log(LogStatus.Info, "Business News Live, Share Market News - Read Latest Finance News, IPO, Mutual Funds News");


            //// ObjectRepository.Driver.Close();
            O.Driver.Quit();

        }





        //  [TestCleanup]


        [TearDown]
        public void AfterTest()

        {





            //StackTrace details for failed Testcases

            var status = TestContext.CurrentContext.Result.Outcome.Status;

            var stacktrace = "<pre>" + TestContext.CurrentContext.Result.StackTrace + "</pre>";


            //var stacktrace = string.IsNullOrEmpty(TestContext.CurrentContext.Result.StackTrace)
            //        ? ""
            //        : string.Format("{0}", TestContext.CurrentContext.Result.StackTrace);



            var errorMessage = TestContext.CurrentContext.Result.Message;






            //Status logstatus;

            //switch (status)
            //{
            //    case TestStatus.Failed:
            //        logstatus = Status.Fail;
            //        break;
            //    case TestStatus.Inconclusive:
            //        logstatus = Status.Warning;
            //        break;
            //    case TestStatus.Skipped:
            //        logstatus = Status.Skip;
            //        break;
            //    default:
            //        logstatus = Status.Pass;
            //        break;


            //}

            //childTest.Log(logstatus, "Test ended with " + logstatus + stackTrace);




            if (status == TestStatus.Failed)
            {
                //   string screenShotPath = GetScreenShot.Capture(O.Driver, "screesnshotname");

                childTest.Log(Status.Fail, "Test ended with " + status + stacktrace);

                //   childTest.Log(Status.Fail, "Snapshot below: " + childTest.AddScreenCaptureFromPath(screenShotPath));


            }

            else if (status == TestStatus.Passed)

            {

                //  string screenShotPath = GetScreenShot.Capture(O.Driver, "screesnshotname");


                childTest.Log(Status.Pass, "Test ended with " + status + stacktrace);

                //  childTest.Log(Status.Pass, "Snapshot below: " + childTest.AddScreenCaptureFromPath(screenShotPath));

                // string screenShotPath = GetScreenShot.Capture(ObjectRepository.Driver, "screesnshotname");

                //    BaseClasses.test.Log(LogStatus.Pass, stackTrace + errorMessage);

                // BaseClasses.test.Log(LogStatus.Pass, "Snapshot below: " + BaseClasses.test.AddScreenCapture(screenShotPath));


            }


            else if (status == TestStatus.Skipped)

            {


            }
















            //   //End test report

            ////   BaseClasses.extent.EndTest(BaseClasses.test);


        }






    }
}