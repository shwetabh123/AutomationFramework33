
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.ObjectModel;
using System.IO;
using OpenQA.Selenium.Interactions;
using System.Drawing;
using AutomationFramework33.AutomationFramework33.Settings;
using NUnit.Framework;

namespace AutomationFramework33.AutomationFramework33.Utility
{

    [TestFixture]
    public class BasePage

        {

            public static bool status = false;
            private static string existingWindowHandle;

        ObjectRepository O = new ObjectRepository();


        public  void click(By locator)
        {


            O.Driver.FindElement(locator).Click();

        }



        public static void ClickwithCssSelector(IWebDriver driver, string selector)
            {
                driver.FindElement(By.CssSelector(selector)).Click();

            }



            public static void clickwithID(IWebDriver driver, string ID)
            {
                driver.FindElement(By.Id(ID)).Click();
            }

            public static void clickwithXapth(IWebDriver driver, string Xpath)
            {
                driver.FindElement(By.XPath(String.Format(Xpath))).Click();
            }



            public static void SendValueMakeItPersist(IWebDriver driver, string value, string XpathforDummyFocus, string xapth, int wait)
            {
                var element = (new WebDriverWait(driver, TimeSpan.FromSeconds(wait)))
                    .Until(ExpectedConditions.ElementIsVisible(By.XPath(xapth)));
                element.Clear();
                element.SendKeys(value);

                Thread.Sleep(10000);
                IWebElement element2 = (new WebDriverWait(driver, TimeSpan.FromSeconds(wait)))
                   .Until(ExpectedConditions.ElementIsVisible(By.XPath(XpathforDummyFocus)));
                element2.Click();

            }
            public static IWebElement GetElementswithXpath(IWebDriver driver, string xapth, int wait)
            {
                return (new WebDriverWait(driver, TimeSpan.FromSeconds(wait)))
                   .Until(ExpectedConditions.ElementIsVisible(By.XPath(xapth)));
            }

            public static IWebElement GetElementwithXpath(IWebDriver driver, string xapth, int wait)
            {
                return (new WebDriverWait(driver, TimeSpan.FromSeconds(wait)))
                   .Until(ExpectedConditions.ElementIsVisible(By.XPath(xapth)));
            }
            public static void FindelementWithXpath(IWebDriver driver, string xapth)
            {
                driver.FindElement(By.XPath(xapth));
            }

            public static void ClickWithWait(IWebDriver driver, string selector, int wait)
            {
                (new WebDriverWait(driver, TimeSpan.FromSeconds(wait)))
                    .Until(ExpectedConditions.ElementIsVisible(By.CssSelector(selector))).Click();
            }

            public static void Select(IWebDriver driver, string selector, string selection)
            {
                var element = new SelectElement(driver.FindElement(By.CssSelector(selector)));
                element.SelectByValue(selection);
            }

            public static void SelectInCEBDropdown(IWebDriver driver, string selector, string selection, int index = 0, IWebElement parentElement = null)
            {
                IWebElement cebdropdown = null;
                if (parentElement == null)
                    cebdropdown = driver.FindElements(By.CssSelector(selector + " + .ceb-dropdown-container")).ElementAt(index);
                else
                    cebdropdown = parentElement.FindElements(By.CssSelector(selector + " + .ceb-dropdown-container")).ElementAt(index);
                cebdropdown.FindElement(By.TagName("button")).Click();
                IWebElement searchBox = driver.FindElement(By.CssSelector(selector + " + .ceb-dropdown-container input.multiselect-search"));
                searchBox.Clear();
                searchBox.SendKeys(selection);
                Thread.Sleep(1000);
                var radioSelect =
                    cebdropdown.FindElements(
                        By.CssSelector("li input[type='radio']")).FirstOrDefault(e => e.Displayed);
                radioSelect.Click();
            }

            public static void SelectInCEBDropdownByValue(IWebDriver driver, string selector, string value, int index = 0, IWebElement parentElement = null)
            {
                IWebElement cebdropdown = null;
                if (parentElement == null)
                    cebdropdown = driver.FindElements(By.CssSelector(selector + " + .ceb-dropdown-container")).ElementAt(index);
                else
                    cebdropdown = parentElement.FindElements(By.CssSelector(selector + " + .ceb-dropdown-container")).ElementAt(index);

                cebdropdown.FindElement(By.TagName("button")).Click();

                var radioSelect =

                    cebdropdown.FindElements(
                        By.CssSelector("li input")).FirstOrDefault(e => e.Displayed && e.GetAttribute("value") == value);
                if (radioSelect != null)
                    radioSelect.Click();
            }

            public static void SelectInDropdownByText(IWebDriver driver, string selector, string selection)
            {
                var element = new SelectElement(driver.FindElement(By.CssSelector(selector)));
                element.SelectByText(selection);
            }


            public static string GetSelectedItemInCEBDropDown(IWebDriver driver, string selector, int index = 0)
            {
                IWebElement cebdropdown = null;

                cebdropdown = driver.FindElements(By.CssSelector(selector + " + .ceb-dropdown-container")).ElementAt(index);


                return cebdropdown.FindElement(By.TagName("button")).Text;
            }
            public static void SelectInCEBDropdownByText(IWebDriver driver, string selector, string text = null, int index = 0, IWebElement parentElement = null)
            {
                IWebElement cebdropdown = null;
                if (parentElement == null)
                    cebdropdown = driver.FindElements(By.CssSelector(selector + " + .ceb-dropdown-container")).ElementAt(index);
                else
                    cebdropdown = parentElement.FindElements(By.CssSelector(selector + " + .ceb-dropdown-container")).ElementAt(index);

                cebdropdown.FindElement(By.TagName("button")).Click();

                if (!string.IsNullOrEmpty(text))
                {
                    var labelSelect =
                        cebdropdown.FindElements(
                                By.CssSelector("li label.radio"))
                            .FirstOrDefault(e => e.Displayed && e.Text.Trim() == text.Trim());
                    if (labelSelect != null)
                    {
                        var radioSelect = labelSelect.FindElement(By.CssSelector("input"));
                        if (radioSelect != null)
                            radioSelect.Click();
                    }
                }
                else
                {
                    var radioSelect =
                        cebdropdown.FindElements(
                                By.CssSelector("li input"))
                            .FirstOrDefault(e => e.Displayed);
                    if (radioSelect != null)
                        radioSelect.Click();
                }
            }

            public static void SelectInMultiSelectCEBDropdownByValue(IWebDriver driver, string selector, string[] values, int index = 0, IWebElement parentElement = null)
            {
                IWebElement cebdropdown = null;
                if (parentElement == null)
                    cebdropdown = driver.FindElements(By.CssSelector(selector + " + .ceb-dropdown-container")).ElementAt(index);
                else
                    cebdropdown = parentElement.FindElements(By.CssSelector(selector + " + .ceb-dropdown-container")).ElementAt(index);
                cebdropdown.FindElement(By.TagName("button")).Click();
                foreach (var value in values)
                {
                    var checkboxSelect =
                        cebdropdown.FindElements(
                            By.CssSelector("li input")).FirstOrDefault(e => e.Displayed && e.GetAttribute("value") == value);
                    if (checkboxSelect != null && bool.Parse(checkboxSelect.GetProperty("checked")) == false)
                        checkboxSelect.Click();
                }
                cebdropdown.Click();
            }

            public static void SelectInMultiSelectCEBDropdownByText(IWebDriver driver, string selector, string[] texts = null, int index = 0, IWebElement parentElement = null)
            {
                IWebElement cebdropdown = null;
                if (parentElement == null)
                    cebdropdown = driver.FindElements(By.CssSelector(selector + " + .ceb-dropdown-container")).ElementAt(index);
                else
                    cebdropdown = parentElement.FindElements(By.CssSelector(selector + " + .ceb-dropdown-container")).ElementAt(index);
                cebdropdown.FindElement(By.TagName("button")).Click();
                if (texts != null && texts.Length > 0)
                {
                    foreach (var text in texts)
                    {
                        if (!string.IsNullOrEmpty(text))
                        {
                            var checkboxLabelSelect =
                                cebdropdown.FindElements(
                                        By.CssSelector("li label.checkbox"))
                                    .FirstOrDefault(e => e.Displayed && e.Text.Trim() == text.Trim());
                            if (checkboxLabelSelect != null)
                            {
                                var checkboxSelect =
                                    checkboxLabelSelect.FindElement(By.CssSelector("input"));
                                try
                                {
                                    if (checkboxSelect != null && bool.Parse(checkboxSelect.GetProperty("checked")) == false)
                                        checkboxSelect.Click();
                                }
                                catch (NullReferenceException ex)
                                {
                                    if (checkboxSelect != null && (checkboxSelect.GetAttribute("checked")) == null)

                                        checkboxSelect.Click();
                                }
                                cebdropdown.Click();

                            }
                        }
                    }
                }
                else
                {
                    var checkboxSelect =
                        cebdropdown.FindElements(
                                By.CssSelector("li input"))
                            .FirstOrDefault(e => e.Displayed);


                }
                cebdropdown.Click();
            }

            public static void RemoveSelectInMultiSelectCEBDropdownByText(IWebDriver driver, string selector, string[] texts = null, int index = 0, IWebElement parentElement = null)
            {
                IWebElement cebdropdown = null;
                if (parentElement == null)
                    cebdropdown = driver.FindElements(By.CssSelector(selector + " + .ceb-dropdown-container")).ElementAt(index);
                else
                    cebdropdown = parentElement.FindElements(By.CssSelector(selector + " + .ceb-dropdown-container")).ElementAt(index);
                cebdropdown.FindElement(By.TagName("button")).Click();
                if (texts != null && texts.Length > 0)
                {
                    foreach (var text in texts)
                    {
                        if (!string.IsNullOrEmpty(text))
                        {
                            var checkboxLabelSelect =
                                cebdropdown.FindElements(
                                        By.CssSelector("li label.checkbox"))
                                    .FirstOrDefault(e => e.Displayed && e.Text.Trim() == text.Trim());
                            if (checkboxLabelSelect != null)
                            {
                                var checkboxSelect =
                                    checkboxLabelSelect.FindElement(By.CssSelector("input"));
                                if (checkboxSelect != null && bool.Parse(checkboxSelect.GetProperty("checked")) == true)
                                    checkboxSelect.Click();

                            }
                        }
                    }
                }
                else
                {
                    var checkboxSelect =
                        cebdropdown.FindElements(
                                By.CssSelector("li input"))
                            .FirstOrDefault(e => e.Displayed);
                    try
                    {
                        if (checkboxSelect != null && bool.Parse(checkboxSelect.GetProperty("checked")) == true)
                            checkboxSelect.Click();
                    }
                    catch (NullReferenceException ex)


                    {


                        if (checkboxSelect != null && (checkboxSelect.GetAttribute("checked")) != null)

                            checkboxSelect.Click();
                    }
                    cebdropdown.Click();
                }

            }
            public static void OpenNewTab(IWebDriver driver, string url)
            {
                int oldwindowsize = 0;
                int newwindowsize = 0;

                //get the current window handles /
                string popupHandle = string.Empty;
                ReadOnlyCollection<string> all_windowHandles = driver.WindowHandles;

                //get the current window handles count
                oldwindowsize = all_windowHandles.Count;

                //Open new tabs
                IJavaScriptExecutor js = driver as IJavaScriptExecutor;
                string title = (string)js.ExecuteScript("window.open();");

                //get the new window handles count
                ReadOnlyCollection<string> all_windowHandles_new = driver.WindowHandles;
                newwindowsize = all_windowHandles_new.Count;
                existingWindowHandle = driver.CurrentWindowHandle;
                foreach (string handle in all_windowHandles_new)
                {
                    if (handle != existingWindowHandle)
                    {
                        popupHandle = handle;

                        break;
                    }
                }

                //switch to new window 
                Thread.Sleep(1000);
                driver.SwitchTo().Window(popupHandle);
                Thread.Sleep(15000);
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl(url);
                Thread.Sleep(10000);
            }



            public static Boolean IsElementVisible(IWebDriver driver, string selector)
            {
                try
                {
                    FindElementWithXpath(driver, selector);
                    return true;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            }

            public static Boolean IsElementNotVisible(IWebDriver driver, string selector)
            {
                try
                {
                    FindElementWithXpath(driver, selector);
                    return false;
                }
                catch (NoSuchElementException)
                {
                    return true;
                }




            }


            //public static bool IsElementDisplayed(IWebDriver driver, string selector)
            //{



            //    IWebElement myElement = UIActions.FindElementWithXpath(driver, selector);

            //    bool result = myElement.Displayed;

            //    if (result == true)
            //    {



            //        Console.WriteLine("Element is  Displayed");


            //        return true;




            //    }


            //    else
            //    {




            //        Console.WriteLine("Element is not   Displayed");



            //        Assert.Fail("Element is not  Displayed");


            //        return false;





            //    }



            //}




            //public static bool IsElementNotDisplayed(IWebDriver driver, string selector)
            //{



            //    IWebElement myElement = UIActions.FindElementWithXpath(driver, selector);

            //    bool result = myElement.Displayed;

            //    if (result == true)
            //    {



            //        Console.WriteLine("Element is  Displayed");



            //        Assert.Fail("Element is  Displayed");


            //        return false;



            //    }


            //    else
            //    {


            //        Console.WriteLine("Element is not Displayed");


            //        return true;
            //    }








            //}



            //public static bool IsElementEnabled(IWebDriver driver, string selector)
            //{



            //    IWebElement myElement = UIActions.FindElementWithXpath(driver, selector);

            //    bool result = myElement.Enabled;

            //    if (result == true)
            //    {




            //        Console.WriteLine("Element is  Enabled");


            //        return true;


            //    }


            //    else
            //    {


            //        Console.WriteLine("Element is not   Enabled");

            //        Assert.Fail("Element is not  Enabled");


            //        return false;



            //    }

            //}


            //public static bool IsElementNotEnabled(IWebDriver driver, string selector)
            //{



            //    IWebElement myElement = UIActions.FindElementWithXpath(driver, selector);

            //    bool result = myElement.Enabled;


            //    if (result == true)
            //    {



            //        Console.WriteLine("Element is  Enabled");



            //        Assert.Fail("Element is  Enabled");


            //        return false;


            //    }


            //    else
            //    {

            //        Console.WriteLine("Element is not Enabled");


            //        return true;
            //    }



            //}

            //Shwetabh Srivastava----Get Latest Downloaded file from Downloaded folder configured in Config file as per desired capabilities

            public static string getLastDownloadedFile(string folder)
            {

                string latestfile = "";
                var files = new DirectoryInfo(folder).GetFiles("*.*");

                DateTime lastupdated = DateTime.MinValue;


                foreach (FileInfo file in files)


                {

                    if (file.LastWriteTime > lastupdated)

                    {

                        lastupdated = file.LastWriteTime;

                        latestfile = file.Name;

                    }


                }

                Console.Write("LatestFileName: " + latestfile);

                return latestfile;


            }


            public static IWebElement GetElement(IWebDriver driver, string selector)
            {
                return driver.FindElement(By.CssSelector(selector));
            }


            public static IWebElement GetElementWithWait(IWebDriver driver, string selector, int wait)
            {
                return (new WebDriverWait(driver, TimeSpan.FromSeconds(wait)))
                    .Until(ExpectedConditions.ElementIsVisible(By.CssSelector(selector)));
            }



            public static string GetAttrForElementById(IWebDriver driver, string Id, string attributeName)
            {

                return driver.FindElement(By.Id(Id)).GetAttribute(attributeName);

            }

            public static string GetAttrForElementByXpath(IWebDriver driver, string xpath, string attributeName)
            {

                return driver.FindElement(By.XPath(xpath)).GetAttribute(attributeName);

            }


            public static string GetAttrForElementByCss(IWebDriver driver, string Value, string attributeName)
            {

                return driver.FindElement(By.CssSelector(Value)).GetAttribute(attributeName);

            }

            public static string GetAttrForElementByCssattribute(IWebDriver driver, string Value, string CSSName)
            {

                return driver.FindElement(By.CssSelector(Value)).GetCssValue(CSSName);

            }

            public static string GetAttrForElementByXpathCSSattribute(IWebDriver driver, string Value, string CSSName)
            {

                var display = driver.FindElement(By.XPath(Value)).GetCssValue(CSSName);
                return display;

            }



            public static IReadOnlyCollection<IWebElement> FindElements(IWebDriver driver, string selector)
            {
                return driver.FindElements(By.CssSelector(selector));
            }

            public static IReadOnlyCollection<IWebElement> FindElementsWithXpath(IWebDriver driver, string selector)
            {
                return driver.FindElements(By.XPath(selector));
            }

            public static IWebElement FindElement(IWebDriver driver, string selector)
            {
                return driver.FindElement(By.CssSelector(selector));
            }

            public static IWebElement FindElementWithXpath(IWebDriver driver, string selector)
            {
                return driver.FindElement(By.XPath(selector));
            }


            public static string GetValueByElement(IWebDriver driver, string selector)
            {
                return driver.FindElement(By.CssSelector(selector)).Text;
            }

            public static IWebElement Drag(IWebDriver driver, String dragfrom)
            {
                return driver.FindElement(By.CssSelector(dragfrom));

            }
            public static IWebElement Drop(IWebDriver driver, String dropTo)
            {
                return driver.FindElement(By.XPath(String.Format(dropTo)));
            }

            public static bool IsElementVisibleByClass(IWebDriver driver, string className)
            {
                return driver.FindElement(By.ClassName(className)).Displayed;
            }

            public static bool IsElementEnabledByClass(IWebDriver driver, string className)
            {
                return driver.FindElement(By.ClassName(className)).Enabled;
            }

            public static bool IsElementVisibleById(IWebDriver driver, string id)
            {
                return driver.FindElement(By.Id(id)).Displayed;
            }

            public static bool IsElementEnabledById(IWebDriver driver, string id)
            {
                return driver.FindElement(By.Id(id)).Enabled;
            }

            public static bool IsElementEnabledByXpath(IWebDriver driver, string Xpath)
            {
                return driver.FindElement(By.XPath(Xpath)).Enabled;
            }

            /*public static void OpenNewTab(IWebDriver driver)
            {

                IJavaScriptExecutor js = driver as IJavaScriptExecutor;
                string title = (string)js.ExecuteScript("window.open();");
            }*/

            public static Boolean SwitchWindows(IWebDriver driver, string title)
            {
                var currentWindow = driver.CurrentWindowHandle;

                List<string> lstWindow = driver.WindowHandles.ToList();

                foreach (string w in lstWindow)
                {
                    Console.WriteLine("w:" + w);
                    if (w != currentWindow)
                    {

                        driver.SwitchTo().Window(w);

                        if (driver.Title == title)
                        {
                            return true;

                        }
                        else
                        {
                            driver.SwitchTo().Window(currentWindow);
                        }

                    }



                }
                return false;
            }


            public static bool SwitchToWindowWithTitle(String title, IWebDriver driver)
            {


                ReadOnlyCollection<string> all_windowHandles = driver.WindowHandles;
                // Set<String> windowHandles = driver.getWindowHandles();
                foreach (String handle in all_windowHandles)
                {
                    driver.SwitchTo().Window(handle);

                    if (driver.Title.Contains(title))
                    {
                        break;
                    }
                }

                return true;
            }

            //public static void WriteToExcel(string data)
            //{
            //    string myPath = @"C:\Users\ssrivastava4\Documents\Visual Studio 2015\Projects\SHWETABH\SHWETABH\Tellurium-11May-Server\Tellurium\Login.xlsx"; // this must be full path.
            //    FileInfo fi = new FileInfo(myPath);
            //    if (!fi.Exists)
            //    {
            //        Console.Out.WriteLine("file doesn't exists!");
            //    }
            //    else
            //    {
            //        var excelApp = new Microsoft.Office.Interop.Excel.Application();
            //        var workbook = excelApp.Workbooks.Open(myPath);
            //        Worksheet worksheet = workbook.ActiveSheet as Worksheet;


            //        Microsoft.Office.Interop.Excel.Range range = worksheet.Cells[1, 1] as Range;
            //        range.Value2 = data;

            //        //excelApp.Visible = true;
            //        workbook.Save();
            //        workbook.Close();
            //    }
            //}

            public static Boolean MouseHoverToElementAndClick(IWebDriver driver, String selector)



            {



                try
                {

                    IWebElement we = driver.FindElement(By.XPath(selector));

                    Actions action = new Actions(driver);
                    action.MoveToElement(we).Build().Perform();

                    Thread.Sleep(15000);

                    action.MoveToElement(we).Click(we).Build().Perform();


                }


                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }




                Console.Write("Mouse Hover to Element and perform click succeed");
                return true;
            }

            public static Boolean MouseHoverToElementAndClick(IWebDriver driver, IWebElement we)



            {



                try
                {
                    Actions action = new Actions(driver);
                    action.MoveToElement(we).Build().Perform();

                    Thread.Sleep(15000);

                    action.MoveToElement(we).Click(we).Build().Perform();
                }


                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }




                Console.Write("Mouse Hover to Element and perform click succeed");
                return true;
            }

            public static Boolean ScrollToElement(IWebDriver driver, String selector)
            {

                try
                {
                    IWebElement we = driver.FindElement(By.CssSelector(selector));

                    Actions action = new Actions(driver);
                    action.MoveToElement(we).Build().Perform();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }
                Console.Write("Mouse Hover to Element and perform click succeed");
                return true;
            }

            public static void getScreenshot(IWebDriver driver)
            {

                // Start Initializing the variables... 
                Console.WriteLine("Initializing the variables...");
                Console.WriteLine();
                Bitmap memoryImage;
                memoryImage = new Bitmap(1000, 900);
                Size s = new Size(memoryImage.Width, memoryImage.Height);

                // Create the graphics 
                Console.WriteLine("Creating Graphics...");
                Console.WriteLine();
                Graphics memoryGraphics = Graphics.FromImage(memoryImage);

                // Copy data from screen 
                Console.WriteLine("Copying data from screen...");
                Console.WriteLine();
                memoryGraphics.CopyFromScreen(0, 0, 0, 0, s);

                //That's it! Save the image in the directory  
                string str = "";
                try
                {
                    //   str = string.Format(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + 
                    //        @"\Screenshot.png"); 


                    string filename = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString();



                    str = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\" + filename + ".png";

                }
                catch (Exception er)
                {
                    Console.WriteLine("Sorry, there was an error: " + er.Message);
                    Console.WriteLine();
                }

                // Save it! 
                Console.WriteLine("Saving the image...");
                memoryImage.Save(str);

                // Write the message, 
                Console.WriteLine("Picture has been saved...");
                Console.WriteLine();

            }




        //        public static string ExtractTextFromPDF(IWebDriver driver, string pdfFilePath, string pdfFileName, string pagenumber)
        //        {
        //            StringBuilder result = new StringBuilder();
        //            // Create a reader for the given PDF file
        //            using (PdfReader reader = new PdfReader(@pdfFilePath + "\\" + pdfFileName))
        //            {
        //                // Read pages
        //                for (int page = 0; page <= reader.NumberOfPages; page++)
        //                {

        //                    int pagenumber1 = Int32.Parse(pagenumber);
        //                    if (page.Equals(pagenumber1))
        //                    {


        //                        SimpleTextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
        //                        string pageText = PdfTextExtractor.GetTextFromPage(reader, page, strategy);
        //                        result.Append(pageText);




        //                    }


        //                }
        //            }

        //            DistributeActions.WriteLog(driver, pdfFilePath, result.ToString());


        //            return result.ToString();
        //        }


        //        public static void ReadPdfFiles(IWebDriver driver, string pdfFilePath, string pdfFileName, int pagenumber, int cordinate1, int coordinate2, int coordinate3, int coordinate4)
        //        {


        //            PdfReader reader = new PdfReader(@pdfFilePath + "\\" + pdfFileName);
        //            string text = string.Empty;
        //            string[] words = null;
        //            try
        //            {

        //                iTextSharp.text.Rectangle rect = new iTextSharp.text.Rectangle(cordinate1, coordinate2, coordinate3, coordinate4);

        //                RenderFilter[] renderFilter = new RenderFilter[1];


        //                renderFilter[0] = new RegionTextRenderFilter(rect);

        //                ITextExtractionStrategy textExtractionStrategy = new FilteredTextRenderListener(new LocationTextExtractionStrategy(), renderFilter);

        //                text = PdfTextExtractor.GetTextFromPage(reader, pagenumber, textExtractionStrategy);

        //                words = text.Split('\n');

        //                //    return words;


        //                foreach (String s in words)

        //                {
        //                    DistributeActions.WriteLog(driver, pdfFilePath, s);



        //                }



        //            }
        //            catch (Exception Ex)
        //            {
        //                reader.Close();
        //                //  return words;
        //            }
        //            finally
        //            {
        //                reader.Close();
        //            }


        //        }


        //        public static string getExcelSheetName(IWebDriver driver, String filepath, String fileName, String Index)
        //        {

        //            String SheetName = null;
        //            try
        //            {

        //                DistributeActions.WriteLog(driver, filepath, "In GetSheetName");

        //                string s = null;

        //                Workbook wb = new Workbook(filepath + "\\" + fileName);



        //                int index = Int32.Parse(Index);


        //                int numberOfSheets = wb.Worksheets.Count;



        //                DistributeActions.WriteLog(driver, filepath, "Number of sheets in this workbook : " + numberOfSheets);



        //                foreach (Worksheet worksheet in wb.Worksheets)
        //                {


        //                    if (worksheet.Index == (index))

        //                    {



        //                        SheetName = worksheet.Name;

        //                        DistributeActions.WriteLog(driver, filepath, "Sheet name for Index " + Index + "  is  " + SheetName);

        //                    }


        //                }




        //            }
        //            catch (Exception e)
        //            {



        //                DistributeActions.WriteLog(driver, filepath, " getExcelSheetName exception :" + e.Message);

        //            }

        //            return SheetName;
        //        }

        //        public static IList<IWebElement> GetallValuesFromCEBDropdown(IWebDriver driver, string selector, int index = 0)
        //        {
        //            IWebElement cebdropdown = null;
        //            cebdropdown = driver.FindElements(By.CssSelector(selector + " + .ceb-dropdown-container")).ElementAt(index);
        //            cebdropdown.FindElement(By.TagName("button")).Click();

        //            IList<IWebElement> Options =
        //                 cebdropdown.FindElements(
        //                         By.CssSelector("li label.checkbox"));


        //            return Options;


        //        }

        //        public static bool IsOptionPresentInCEBDropDown(IWebDriver driver, string Selector, string Option)
        //        {
        //            try
        //            {
        //                bool flag = false;
        //                IWebElement cebdropdown = null;
        //                cebdropdown = driver.FindElement(By.CssSelector(Selector));
        //                cebdropdown.Click();
        //                string[] values = cebdropdown.Text.Split(new string[] { "\r\n" }, StringSplitOptions.None);
        //                if (Option != null)
        //                {
        //                    for (int j = 0; j < values.Length; j++)
        //                    {
        //                        if (Option.ToLower().Trim() == values[j].ToLower().Trim())
        //                        {
        //                            flag = true;
        //                            break;
        //                        }
        //                    }
        //                }

        //                return flag;
        //            }
        //            catch (Exception e)
        //            {
        //                Console.WriteLine(e.Message);
        //                return false;
        //            }
        //        }

        //        public static IWebElement ExpandRootElement(IWebDriver driver, IWebElement element)
        //        {
        //            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
        //            IWebElement ele = (IWebElement)js.ExecuteScript("return arguments[0].shadowRoot", element);
        //            return ele;
        //        }



        //    }
        //}






    }
}
