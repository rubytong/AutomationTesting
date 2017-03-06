﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using Core.Selen;
using XCartTesting.Common;
using System.Diagnostics;

namespace XCartTesting.Hooks
{
    [Binding]
    public sealed class BaseHooks
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            Browser.DriversPath = Constants.DriversPath;
            Browser.Name = Constants.Browser;
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Browser.Current.Close();
            Browser.Current.Quit();

            //Process[] pro = Process.GetProcessesByName("WerFault");
            //foreach (var p in pro) p.Kill();
            //Browser.Current.Dispose();
        }
    }
}