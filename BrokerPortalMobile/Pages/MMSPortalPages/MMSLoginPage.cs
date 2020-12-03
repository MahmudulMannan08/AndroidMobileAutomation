using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokerPortalMobile.Pages.MMSPortalPages
{
    public class MMSLoginPage : TestBase, IPage
    {
        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_Login1_UserName")]
        public IWebElement txtUserId;

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_Login1_Password")]
        public IWebElement txtPassword;

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_Login1_LoginButton")]
        public IWebElement btnSignin;

        public string Url
        {
            get
            {
                return "";
            }
        }

        public void SigninToMMSPortal(string userid, string password)
        {
            UIHelper.WaitForElementVisible(txtUserId, 30);
            //UIHelper.EnterText(txtUserId, userid);
            //UIHelper.EnterText(txtPassword, password);
            //UIHelper.ClickOnLink(btnSignin);
            //UIHelper.WaitForPageLoad(30);

            if (UIHelper.IsElementDisplayed(By.Id("ctl00_ContentPlaceHolder1_Login1_UserName")))
            {
                UIHelper.EnterText(txtUserId, userid);
                UIHelper.EnterText(txtPassword, password);
                UIHelper.ClickOnLink(btnSignin);
                UIHelper.WaitForPageLoad(30);
            }
        }
    }
}
