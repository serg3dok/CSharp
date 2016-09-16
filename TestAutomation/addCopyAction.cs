using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace se_builder {
  public class addCopyAction {
    static void Main(string[] args) {
      IWebDriver wd = new RemoteWebDriver(DesiredCapabilities.Firefox());
      try {
        var wait = new WebDriverWait(wd, TimeSpan.FromSeconds(60));
        wd.Navigate().GoToUrl("http://omnitfs:8080/tfs/Production/MTS/_build");
        wd.FindElement(By.XPath("//div[@class='buildvnext-tree']//label[.='OnDemand-DevTrunk']")).Click();
        wd.FindElement(By.LinkText("Edit")).Click();
        wd.FindElement(By.XPath("//div[@id='123']/div[1]/span")).Click();
        wd.FindElement(By.XPath("//div[@id='190']//label[.='Deploy']")).Click();
        wd.FindElement(By.XPath("//div[@class='taskeditor-add-tasks-dialog']/div[7]/div[3]/button")).Click();
        wd.FindElement(By.Id("ok")).Click();
        wd.FindElement(By.CssSelector("div.task-name.required-input-message")).Click();
        wd.FindElement(By.Id("SourcePath")).Click();
        wd.FindElement(By.Id("SourcePath")).Clear();
        wd.FindElement(By.Id("SourcePath")).SendKeys("$(build.sourcesDirectory)\\");
        wd.FindElement(By.CssSelector("div.drop.hover")).Click();
        wd.FindElement(By.XPath("//ul[@class='items']//li[.='OnDemandServerDeployment']")).Click();
        wd.FindElement(By.Id("TargetPath")).Click();
        wd.FindElement(By.Id("TargetPath")).Clear();
        wd.FindElement(By.Id("TargetPath")).SendKeys("$(deploymentLocation)\\");
        wd.FindElement(By.CssSelector("span.icon.icon-save")).Click();
        wd.FindElement(By.Id("ok")).Click();
        wd.FindElement(By.XPath("//div[@class='buildvnext-tree']//label[.='All build definitions']")).Click();
      } finally { wd.Quit(); }
    }
    
    public static bool isAlertPresent(IWebDriver wd) {
        try {
            wd.SwitchTo().Alert();
            return true;
        } catch (NoAlertPresentException e) {
            return false;
        }
    }
  }
}
