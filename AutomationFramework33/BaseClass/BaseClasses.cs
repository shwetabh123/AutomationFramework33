using AutomationFramework33.AutomationFramework33.Configuration;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using TestContext = NUnit.Framework.TestContext;

namespace AutomationFramework33.AutomationFramework33.BaseClass
{


    [TestFixture]
    public class BaseClasses
    {

        public static ExtentReports extent;

        public static  ExtentTest test;

       


        public BrowserType _browserType;

        public BaseClasses(BrowserType browser)
        {
            _browserType = browser;
        }

        //public static ThreadLocal<ExtentTest> parentTest = new ThreadLocal<ExtentTest>();
        //public static ThreadLocal<ExtentTest> childTest = new ThreadLocal<ExtentTest>();

        //public static ThreadLocal<ExtentTest> childTestnew = new ThreadLocal<ExtentTest>();




        public static FirefoxProfile GetFirefoxptions()
        {
            FirefoxProfile profile = new FirefoxProfile();
            FirefoxProfileManager manager = new FirefoxProfileManager();


            // Logger.Info(" Using Firefox Profile ");


            return profile;
        }

        public static FirefoxOptions GetOptions()
        {




            FirefoxProfileManager manager = new FirefoxProfileManager();

            FirefoxOptions options = new FirefoxOptions()
            {
                Profile = manager.GetProfile("default"),
                AcceptInsecureCertificates = true,



            };
            return options;


        }
        public static ChromeOptions GetChromeOptions()
        {
            ChromeOptions option = new ChromeOptions();
            option.AddArgument("start-maximized");
            //option.AddArgument("--headless");
            //option.AddExtension(@"C:\Users\rahul.rathore\Desktop\Cucumber\extension_3_0_12.crx");
          
            
            //      Logger.Info(" Using Chrome Options ");
            return option;
        }

        public static InternetExplorerOptions GetIEOptions()
        {
            InternetExplorerOptions options = new InternetExplorerOptions();
            options.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
            options.EnsureCleanSession = true;
            options.ElementScrollBehavior = InternetExplorerElementScrollBehavior.Bottom;
            //        Logger.Info(" Using Internet Explorer Options ");
            return options;
        }


        //public static FirefoxDriver GetFirefoxDriver()
        //{
        //    //FirefoxOptions options = new FirefoxOptions();
        //    //FirefoxDriver driver = new FirefoxDriver(GetFirefoxptions());

        //    FirefoxOptions option = new FirefoxOptions();
        //    ICapabilities cap = option.ToCapabilities();

        //    FirefoxProfileManager mangage = new FirefoxProfileManager();
        //    FirefoxProfile profile = mangage.GetProfile(mangage.ExistingProfiles[0]);

        //    FirefoxDriver driver = new FirefoxDriver(); ;


        //    return driver;
        //}

        //public static ChromeDriver GetChromeDriver()
        //{
        //    ChromeDriver driver = new ChromeDriver(GetChromeOptions());
        //    return driver;
        //}

        //public static InternetExplorerDriver GetIEDriver()
        //{
        //    InternetExplorerDriver driver = new InternetExplorerDriver(GetIEOptions());
        //    return driver;
        //}

        ////private static PhantomJSDriver GetPhantomJsDriver()
        ////{
        ////    PhantomJSDriver driver = new PhantomJSDriver(GetPhantomJsDrvierService());

        ////    return driver;
        ////}

        ////private static PhantomJSOptions GetPhantomJsptions()
        ////{
        ////    PhantomJSOptions option = new PhantomJSOptions();
        ////    option.AddAdditionalCapability("handlesAlerts", true);
        ////    Logger.Info(" Using PhantomJS Options  ");
        ////    return option;
        ////}

        ////private static PhantomJSDriverService GetPhantomJsDrvierService()
        ////{
        ////    PhantomJSDriverService service = PhantomJSDriverService.CreateDefaultService();
        ////    service.LogFile = "TestPhantomJS.log";
        ////    service.HideCommandPromptWindow = false;
        ////    service.LoadImages = true;
        ////    Logger.Info(" Using PhantomJS Driver Service  ");
        ////    return service;
        ////}


        //public static RemoteWebDriver getDriver(String browser)
        //{
        //    DesiredCapabilities Capabilities = new DesiredCapabilities();

        //    Capabilities.SetCapability(CapabilityType.BrowserName, "firefox");

        //    string GridURL = "http://localhost:4444/wd/hub";

        //    return new RemoteWebDriver(new Uri(GridURL), Capabilities);
        //}






        public static IWebDriver GetFirefoxDriver()
        {

            //IWebDriver driver = null;

            //FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"C:\Automation\Driver");
            //service.FirefoxBinaryPath = @"C:\Program Files (x86)\Mozilla Firefox\firefox.exe";


            //FirefoxOptions options = new FirefoxOptions();
            //options.SetPreference("browser.download.folderList", 2);

            //options.SetPreference("browser.download.manager.showWhenStarting", false);
            ////options.SetPreference("browser.download.dir", DriverAndLogin.downloadFilepath);
            ////options.SetPreference("browser.download.downloadDir", DriverAndLogin.downloadFilepath);
            ////options.SetPreference("browser.download.defaultFolder", DriverAndLogin.downloadFilepath);


            //options.SetPreference("pref.downloads.disable_button.edit_actions", false);

            //options.SetPreference("browser.download.manager.alertOnEXEOpen", false);
            //options.SetPreference("browser.helperApps.neverAsk.saveToDisk",
            //      "application/msword, application/csv, application/ris, text/csv, image/png, application/pdf, text/html, text/plain, application/zip, application/x-zip, application/x-zip-compressed, application/download, application/octet-stream");

            //options.SetPreference("browser.helperApps.neverAsk.saveToDisk", "application/pdf");

            //options.SetPreference("browser.helperApps.neverAsk.saveToDisk", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");

            //options.SetPreference("browser.helperApps.neverAsk.saveToDisk", "application/xls;text/csv");

            //options.SetPreference("browser.helperApps.neverAsk.saveToDisk", "text/csv,application/x-msexcel,application/excel,application/x-excel,application/vnd.ms-excel,image/png,image/jpeg,text/html,text/plain,application/msword,application/xml");

            //options.SetPreference("browser.download.manager.showWhenStarting", false);
            //options.SetPreference("browser.download.manager.focusWhenStarting", false);
            //options.SetPreference("browser.download.useDownloadDir", true);
            //options.SetPreference("browser.helperApps.alwaysAsk.force", false);
            //options.SetPreference("browser.download.manager.alertOnEXEOpen", false);
            //options.SetPreference("browser.download.manager.closeWhenDone", true);
            //options.SetPreference("browser.download.manager.showAlertOnComplete", false);
            //options.SetPreference("browser.download.manager.useWindow", false);
            //options.SetPreference("services.sync.prefs.sync.browser.download.manager.showWhenStarting", false);
            //options.SetPreference("pdfjs.disabled", true);


            //driver = new FirefoxDriver(service);

            //driver = new FirefoxDriver(options); 




            // var binary = new FirefoxBinary(@"C:\Program Files (x86)\Mozilla Firefox\firefox.exe");


            var profile = new FirefoxProfile();


            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"C:\Automation\Driver");


            //   service.FirefoxBinaryPath = @"C:\Program Files (x86)\Mozilla Firefox\firefox.exe";

            var options = new FirefoxOptions();
            options.SetPreference("webdriver.gecko.driver", @"C:\Automation\Driver\geckodriver.exe");

            IWebDriver driver = new FirefoxDriver();



            return driver;
        }

        public static IWebDriver GetChromeDriver()
        {
            IWebDriver driver = new ChromeDriver(GetChromeOptions());
            return driver;
        }

        public static IWebDriver GetIEDriver()
        {


            //  Driver = new InternetExplorerDriver(options);

          

            IWebDriver driver = new InternetExplorerDriver( GetIEOptions());
            return driver;
        }


        //  [ClassInitialize]

         [OneTimeSetUp]

       
        public  void Setup()

        {




            // Relevantcodes extent Report 2.41
            //*******************************************************************************************



            // //To obtain the current solution path/project path

            // string pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;

            // string actualPath = pth.Substring(0, pth.LastIndexOf("bin"));

            // string projectPath = new Uri(actualPath).LocalPath;


            // Console.WriteLine(projectPath);

            // //Append the html report file to current project path

            // string reportPath = projectPath + "Report\\TestRunReport.html";

            // Console.WriteLine(reportPath);



            // //Boolean value for replacing exisisting report

            //extent = new ExtentReports(reportPath, true);



            // //Add QA system info to html report

            // extent.AddSystemInfo("Host Name", "Shwetabh")

            //     .AddSystemInfo("Environment", "Stage")

            //    .AddSystemInfo("Username", "shwetabh123");



            // //Adding config.xml file

            // extent.LoadConfig(projectPath + "extent-config.xml"); //Get the config.xml file from http://extentreports.com




            //******************************************



            //aventstack extentreport 3.0.0

            //****************************************************

             //To obtain the current solution path/project path

             string pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;

             string actualPath = pth.Substring(0, pth.LastIndexOf("bin"));

             string projectPath = new Uri(actualPath).LocalPath;


             Console.WriteLine(projectPath);

             //Append the html report file to current project path

             string reportPath = projectPath + "Report\\TestRunReport.html";

             Console.WriteLine(reportPath);


            ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter(reportPath);
           
            
            //htmlReporter.Configuration().setReportName("My Test Report");
            //htmlReporter.config().setEncoding("utf-8");
            //htmlReporter.config().setTheme(Theme.DARK);
            //	htmlReporter.config().setTimeStampFormat("mm/dd/yyyy hh:mm:ss a");


            // make the charts visible on report open
            htmlReporter.Configuration().ChartVisibilityOnOpen = true;


            // report title
            htmlReporter.Configuration().DocumentTitle = "aventstack - ExtentReports";

            // encoding, default = UTF-8
            htmlReporter.Configuration().Encoding = "UTF-8";

            htmlReporter.Configuration().Theme = Theme.Standard;

            // report or build name
            htmlReporter.Configuration().ReportName = "Build-1224";

            // chart location - top, bottom
            htmlReporter.Configuration().ChartLocation = ChartLocation.Top;

            // theme - standard, dark
            //htmlReporter.Configuration().Theme = Theme.Dark;

            // add custom css
            htmlReporter.Configuration().CSS = "css-string";

            // add custom javascript
            htmlReporter.Configuration().JS = "js-string";


            // create ExtentReports and attach reporter(s)
            extent = new ExtentReports();

            extent.AddSystemInfo("Platform", "Windows");

            extent.AttachReporter(htmlReporter);









        }



        //[SetUp]


        //public  void InitializeTest()

        //{


        //    InitWebDriver(_browserType);

        //}




        ////[AssemblyInitialize]

        ////[OneTimeSetUp]



        //public static void InitWebDriver(BrowserType browsertype)

        //{


        //    ObjectRepository.Config = new AppConfigReader();



        //    if (browsertype == BrowserType.Chrome)

        //        ObjectRepository.Driver = GetChromeDriver();


        //    else if (browsertype == BrowserType.IExplorer)


        //        ObjectRepository.Driver = GetIEDriver();






        //    //switch (ObjectRepository.Config.GetBrowser())
        //    //{
        //    //    case BrowserType.Firefox:
        //    //        ObjectRepository.Driver = GetFirefoxDriver();
        //    //        //  Logger.Info(" Using Firefox Driver  ");



        //    //        break;

        //    //    case BrowserType.Chrome:
        //    //        ObjectRepository.Driver = GetChromeDriver();
        //    //        //      Logger.Info(" Using Chrome Driver  ");


        //    //       break;

        //    //    case BrowserType.IExplorer:
        //    //        ObjectRepository.Driver = GetIEDriver();
        //    //        //    Logger.Info(" Using Internet Explorer Driver  ");


        //    //        break;



        //    //    default:
        //    //        throw new NoSuitableDriverFound("Driver Not Found : " + ObjectRepository.Config.GetBrowser().ToString());










        //    //}


        //    ObjectRepository.Driver.Manage()
        //         .Timeouts().PageLoad = TimeSpan.FromSeconds(ObjectRepository.Config.GetPageLoadTimeOut());



        //    ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(ObjectRepository.Config.GetElementLoadTimeOut());


        //    ObjectRepository.Driver.Manage().Window.Maximize();
        //    //BrowserHelper.BrowserMaximize();



        //}

        //  [AssemblyCleanup]

        //  [ClassCleanup]

        [OneTimeTearDown]

        public  void TearDown()
        {
            //if (ObjectRepository.Driver != null)
            //{
            //    //ObjectRepository.Driver.Close();
            //ObjectRepository.Driver.Quit();



            //End Report
           // BaseClasses.extent.EndTest(BaseClasses.test);

           // extent.RemoveTest(test);


            BaseClasses.extent.Flush();

            //    BaseClasses.extent.Close();



           // }

        }
    }
}
