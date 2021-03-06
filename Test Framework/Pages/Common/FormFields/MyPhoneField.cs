﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epiq.ETS.TCMS.Anywhere.Testing.E2ETest.Test_Framework.Pages.Common
{
    public class MyPhoneField : PageObject
    {
        private const string FIELD_LOCATOR_BY_ID_TEMPLATE = "//my-phone[@id='{0}']";
        private const string FIELD_INPUT_LOCATOR_BY_ID_TEMPLATE = "//input[@id='{0}']";

        private String fieldId;

        public MyPhoneField(IWebDriver driver, string id) : base(driver, null)
        {
            this.fieldId = id;
        }

        public string Label
        {
            get
            {
                IWebElement element = this.WaitForElementToBeVisible(By.XPath(string.Format(FIELD_LOCATOR_BY_ID_TEMPLATE, fieldId)));
                return element.GetAttribute("label");
            }
        }

        public string Value
        {
            get
            {
                IWebElement element = this.WaitForElementToBeVisible(By.XPath(String.Format(FIELD_INPUT_LOCATOR_BY_ID_TEMPLATE, fieldId)));
                string ret = element.GetAttribute("value");
                if (ret != null)
                    return ret;
                else
                    return "";
            }
            set
            {
                IWebElement element = this.WaitForElementToBeVisible(By.XPath(String.Format(FIELD_INPUT_LOCATOR_BY_ID_TEMPLATE, fieldId)));
                this.ClearAndType(element, value);
            }
        }

    }
}
