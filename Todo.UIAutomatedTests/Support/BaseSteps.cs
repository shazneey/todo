using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace Todo.UIAutomatedTests.Pages
{
    public class BaseSteps : Steps
    {
        protected static T On<T>() where T : IVerifiable, new()
        {
            var page = new T();
            page.Verify();
            return page;
        }
    }
}
