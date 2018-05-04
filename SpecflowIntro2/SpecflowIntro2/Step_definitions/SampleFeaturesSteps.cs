using SpecflowIntro2.Step_definitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecflowIntro2
{
    
    [Binding]
    public class ParametersInFeatureFileSteps
    {
        [Given(@"I am on the web page ""(.*)""")]
        public void GivenIAmOnTheWebPage(string p0)
        {
            Console.WriteLine("I am on page " + p0);
        }

        [Then(@"I verify that title of the page contains ""(.*)""")]
        public void ThenIVerifyThatTitleOfThePageContains(string p0)
        {
            Console.WriteLine("Title of the web page is " + p0);
        }
    }
}





