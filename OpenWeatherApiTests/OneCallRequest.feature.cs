﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.1.0.0
//      SpecFlow Generator Version:3.1.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace OpenWeatherApiTests
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("OneCallRequest", Description="\tThe One Call Request API should be able to provide a general overview of the Wea" +
        "ther Forecast when requested", SourceFile="OneCallRequest.feature", SourceLine=0)]
    public partial class OneCallRequestFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "OneCallRequest.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "OneCallRequest", "\tThe One Call Request API should be able to provide a general overview of the Wea" +
                    "ther Forecast when requested", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void IAmAbleToFindTheHottestDayOfTheNextWeekForAGivenCity(string city, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I am able to find the Hottest Day of the next week for a given City", null, exampleTags);
#line 4
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 5
 testRunner.When(string.Format("I make a OneCall Request to get the Weather for \'{0}\'", city), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 6
 testRunner.Then(string.Format("I receive the expected Weather Report for \'{0}\'", city), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 7
 testRunner.And("I am able to find the Hottest Day within the Response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("I am able to find the Hottest Day of the next week for a given City, london", SourceLine=9)]
        public virtual void IAmAbleToFindTheHottestDayOfTheNextWeekForAGivenCity_London()
        {
#line 4
this.IAmAbleToFindTheHottestDayOfTheNextWeekForAGivenCity("london", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("I am able to find the Hottest Day of the next week for a given City, paris", SourceLine=9)]
        public virtual void IAmAbleToFindTheHottestDayOfTheNextWeekForAGivenCity_Paris()
        {
#line 4
this.IAmAbleToFindTheHottestDayOfTheNextWeekForAGivenCity("paris", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("I am able to find the Hottest Day of the next week for a given City, chicago", SourceLine=9)]
        public virtual void IAmAbleToFindTheHottestDayOfTheNextWeekForAGivenCity_Chicago()
        {
#line 4
this.IAmAbleToFindTheHottestDayOfTheNextWeekForAGivenCity("chicago", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("I am able to find the Hottest Day of the next week for a given City, brisbane", SourceLine=9)]
        public virtual void IAmAbleToFindTheHottestDayOfTheNextWeekForAGivenCity_Brisbane()
        {
#line 4
this.IAmAbleToFindTheHottestDayOfTheNextWeekForAGivenCity("brisbane", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("I am able to find the Hottest Day of the next week for a given City, tokyo", SourceLine=9)]
        public virtual void IAmAbleToFindTheHottestDayOfTheNextWeekForAGivenCity_Tokyo()
        {
#line 4
this.IAmAbleToFindTheHottestDayOfTheNextWeekForAGivenCity("tokyo", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("I am able to find the Minimum and Maximum Temperature for the current day for a g" +
            "iven city", SourceLine=15)]
        public virtual void IAmAbleToFindTheMinimumAndMaximumTemperatureForTheCurrentDayForAGivenCity()
        {
            string[] tagsOfScenario = ((string[])(null));
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I am able to find the Minimum and Maximum Temperature for the current day for a g" +
                    "iven city", null, ((string[])(null)));
#line 16
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 17
 testRunner.When("I make a OneCall Request to get the Weather for \'paris\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 18
 testRunner.Then("I am able to find the minimum and maximum temperature for the current day", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion
