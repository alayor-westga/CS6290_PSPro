﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.8.0.0
//      SpecFlow Generator Version:3.8.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace E2ETests.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.8.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Manage Complaint As Investigator")]
    public partial class ManageComplaintAsInvestigatorFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "ManageComplaintAsInvestigator.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Manage Complaint As Investigator", "\tManage a complaint as investigator", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 4
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "type",
                        "username",
                        "password",
                        "first_name",
                        "last_name",
                        "gender",
                        "hiredate",
                        "birthdate",
                        "assignment"});
            table11.AddRow(new string[] {
                        "supervisor",
                        "s-001",
                        "4567",
                        "Super",
                        "Visor",
                        "M",
                        "2000-01-01",
                        "1970-01-01",
                        "assigment1"});
            table11.AddRow(new string[] {
                        "investigator",
                        "i-001",
                        "4567",
                        "Investi",
                        "Gator",
                        "M",
                        "2000-01-01",
                        "1970-01-01",
                        "assigment1"});
            table11.AddRow(new string[] {
                        "officer",
                        "",
                        "",
                        "Offi",
                        "Cer",
                        "F",
                        "2010-01-01",
                        "1990-01-01",
                        "assigment2"});
#line 5
    testRunner.Given("personnel exists on the DB with this info", ((string)(null)), table11, "Given ");
#line hidden
#line 10
    testRunner.And("supervisor \"s-001\" logs in with password \"4567\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "first_name",
                        "last_name",
                        "address1",
                        "address2",
                        "city",
                        "state",
                        "zip_code",
                        "phone_number",
                        "email_address",
                        "officer",
                        "allegation",
                        "summary"});
            table12.AddRow(new string[] {
                        "Citi",
                        "Zen",
                        "123 Main St.",
                        "",
                        "San Jose",
                        "California",
                        "89900",
                        "555-555-5555",
                        "citizen@example.com",
                        "Offi Cer",
                        "Ethics Violation",
                        "Complaint summary example"});
#line 11
 testRunner.And("a complaint with this info is created", ((string)(null)), table12, "And ");
#line hidden
#line 14
 testRunner.And("the user logs out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("See active complaint")]
        public virtual void SeeActiveComplaint()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("See active complaint", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 17
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
#line 4
this.FeatureBackground();
#line hidden
#line 18
 testRunner.When("investigator \"i-001\" logs in with password \"4567\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                            "officer",
                            "citizen",
                            "allegation"});
                table13.AddRow(new string[] {
                            "Offi Cer",
                            "Citi Zen",
                            "Ethics Violation"});
#line 19
 testRunner.Then("investigator should see a complaint with this info", ((string)(null)), table13, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
