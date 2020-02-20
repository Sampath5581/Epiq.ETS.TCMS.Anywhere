﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Epiq.ETS.TCMS.Anywhere.Testing.E2ETest.Features.Claims
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("AddDSOClaimant")]
    [NUnit.Framework.CategoryAttribute("Regression")]
    [NUnit.Framework.CategoryAttribute("ReactJS")]
    public partial class AddDSOClaimantFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ADDDSOClaims.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "AddDSOClaimant", "\tIn order to verify DSO Page functionality an Add DSO Claimants in DSO Page", ProgrammingLanguage.CSharp, new string[] {
                        "Regression",
                        "ReactJS"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
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
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("001 - DSO Page-Verify header,Bread crumb and sub header")]
        public virtual void _001_DSOPage_VerifyHeaderBreadCrumbAndSubHeader()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("001 - DSO Page-Verify header,Bread crumb and sub header", ((string[])(null)));
#line 7
 this.ScenarioSetup(scenarioInfo);
#line 9
 testRunner.Given("I enter to DSO page as superuser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 10
    testRunner.Then("I see DSO Management header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 11
    testRunner.And("I see breadcrumb DashboardDSO Claimants and subheader DSO Claimants", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
    testRunner.Then("I SignOut from the Unity Application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("002 - DSO Page- Case/debtor claimants Filter and Sort")]
        [NUnit.Framework.TestCaseAttribute("01/01/17", "12/12/18", "Open", "Completed", "Active", new string[0])]
        public virtual void _002_DSOPage_CaseDebtorClaimantsFilterAndSort(string fromdate, string toDate, string caseStatus, string dsoInitial, string dsoNotice, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("002 - DSO Page- Case/debtor claimants Filter and Sort", exampleTags);
#line 15
this.ScenarioSetup(scenarioInfo);
#line 16
testRunner.Given("I enter to DSO page as superuser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 17
   testRunner.Then("Verify sorting on Grid \'CLAIMANT NAME\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 18
     testRunner.When("I click on filter search Icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 19
         testRunner.Then(string.Format("I input all the fields data {0} and {1} and {2} and {3} and {4}", fromdate, toDate, caseStatus, dsoInitial, dsoNotice), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 20
   testRunner.Then("verify the filtered data on Grid \'01/01/17\' and \'12/12/18 \'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 21
      testRunner.Then("I SignOut from the Unity Application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("003 - DSO Page- Input all filter fields and Reset")]
        [NUnit.Framework.CategoryAttribute("US226485")]
        public virtual void _003_DSOPage_InputAllFilterFieldsAndReset()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("003 - DSO Page- Input all filter fields and Reset", new string[] {
                        "US226485"});
#line 30
this.ScenarioSetup(scenarioInfo);
#line 31
testRunner.Given("I enter to DSO page as superuser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 32
    testRunner.When("I click on filter search Icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 33
    testRunner.Then("I input all the fields data 11/11/17 and 12/12/17 and All and All and All", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 34
    testRunner.Then("I click Reset", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 35
    testRunner.Then("I SignOut from the Unity Application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("004 - DSO Page-Add DSO claimant with Existing Debtor&Joint Debtor Employer")]
        [NUnit.Framework.CategoryAttribute("DSOClaimsAdd")]
        [NUnit.Framework.CategoryAttribute("US226486")]
        public virtual void _004_DSOPage_AddDSOClaimantWithExistingDebtorJointDebtorEmployer()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("004 - DSO Page-Add DSO claimant with Existing Debtor&Joint Debtor Employer", new string[] {
                        "DSOClaimsAdd",
                        "US226486"});
#line 39
 this.ScenarioSetup(scenarioInfo);
#line 40
testRunner.Given("I enter to DSO page as superuser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 41
   testRunner.When("I click DSO claimant on DSO Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 42
        testRunner.Then("I see Add DSO Claimants header on Claimants page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 43
        testRunner.Then("Input \'LOUIS\' and I select debtorname \'12-32267 / LOUIS SCHOSSLER\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 44
     testRunner.And("I input \'TEST\' and \'TEST\' and \'9505616939\' text fields information", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 45
     testRunner.Then("I input \'Both\' and \'AL\' and \'Sushma\' and \'mpike\' dropdown fields information", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 46
     testRunner.Then("I Save claimant", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 47
     testRunner.Then("I SignOut from the Unity Application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("005 - DSO Page-Add DSO claimant with New Debtor-Individual&New Joint Debtor Emplo" +
            "yer-Individual")]
        [NUnit.Framework.CategoryAttribute("DSOClaimsAdd")]
        [NUnit.Framework.CategoryAttribute("US226486")]
        public virtual void _005_DSOPage_AddDSOClaimantWithNewDebtor_IndividualNewJointDebtorEmployer_Individual()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("005 - DSO Page-Add DSO claimant with New Debtor-Individual&New Joint Debtor Emplo" +
                    "yer-Individual", new string[] {
                        "DSOClaimsAdd",
                        "US226486"});
#line 51
 this.ScenarioSetup(scenarioInfo);
#line 52
testRunner.Given("I enter to DSO page as superuser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 53
 testRunner.When("I click DSO claimant on DSO Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 54
       testRunner.Then("I see Add DSO Claimants header on Claimants page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 55
       testRunner.Then("I input \'LOUIS\' and I select debtorname \'12-32267 / LOUIS SCHOSSLER\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 56
       testRunner.Then("I input \'TEST\' and \'TEST\' and \'9505616939\' text fields information", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 57
    testRunner.Then("I input \'Both\' and \'AK\' and \'mpike\' and \'Sushma\' dropdown fields information", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 58
 testRunner.When("I select \'New Debtor Employer\' type", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 59
 testRunner.When("I select \'Individual\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 60
       testRunner.Then("I input Debtor title as \'Miss\' for \'Individual\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 61
    testRunner.Then("I input Debtor Firstname as \'Paul\' and MiddleName as \'Kristy\' and Lastname as \'BR" +
                    "AIN\' for \'Individual\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 62
 testRunner.When("I select \'New Joint Debtor Employer\' type", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 63
 testRunner.When("I select Joint debtor \'Individual\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 64
    testRunner.Then("I input Joint Debtor title as \'Mr.\' for \'Individual\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 65
    testRunner.Then("I input Joint Debtor Firstname as \'Brain\' and MiddleName as \'heather\' and Lastnam" +
                    "e as \'Iravanne\' for \'Individual\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 66
    testRunner.Then("I Save claimant", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 67
    testRunner.Then("I SignOut from the Unity Application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("006 - DSO Page-Add DSO claimant with New Debtor-Corporation&New Joint Debtor Empl" +
            "oyer-Corporation")]
        [NUnit.Framework.CategoryAttribute("DSOClaimsAdd")]
        [NUnit.Framework.CategoryAttribute("US226486")]
        public virtual void _006_DSOPage_AddDSOClaimantWithNewDebtor_CorporationNewJointDebtorEmployer_Corporation()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("006 - DSO Page-Add DSO claimant with New Debtor-Corporation&New Joint Debtor Empl" +
                    "oyer-Corporation", new string[] {
                        "DSOClaimsAdd",
                        "US226486"});
#line 72
 this.ScenarioSetup(scenarioInfo);
#line 73
 testRunner.Given("I enter to DSO page as superuser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 74
    testRunner.When("I click DSO claimant on DSO Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 75
        testRunner.Then("I see Add DSO Claimants header on Claimants page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 76
        testRunner.Then("I input \'LOUIS\' and I select debtorname \'12-32267 / LOUIS SCHOSSLER\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 77
        testRunner.Then("I input \'TEST\' and \'TEST\' and \'9505616939\' text fields information", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 78
     testRunner.Then("I input \'Both\' and \'AL\' and \'mpike\' and \'Sushma\' dropdown fields information", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 79
 testRunner.When("I select \'New Debtor Employer\' type", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 80
 testRunner.When("I select \'Corporation\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 81
 testRunner.When("I input Debtor displayname as \'paul\' for \'Corporation\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 82
 testRunner.When("I select \'New Joint Debtor Employer\' type", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 83
 testRunner.When("I select Joint debtor \'Corporation\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 84
 testRunner.When("I input Joint Debtor displayname as \'paul\' for \'Corporation\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 85
      testRunner.Then("I Save claimant", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 86
   testRunner.Then("I SignOut from the Unity Application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("007 - DSO Page-Add DSO claimant with New Debtor-Idividual&New Joint Debtor Employ" +
            "er-Corporation")]
        [NUnit.Framework.CategoryAttribute("DSOClaimsAdd")]
        [NUnit.Framework.CategoryAttribute("US226486")]
        public virtual void _007_DSOPage_AddDSOClaimantWithNewDebtor_IdividualNewJointDebtorEmployer_Corporation()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("007 - DSO Page-Add DSO claimant with New Debtor-Idividual&New Joint Debtor Employ" +
                    "er-Corporation", new string[] {
                        "DSOClaimsAdd",
                        "US226486"});
#line 90
 this.ScenarioSetup(scenarioInfo);
#line 91
 testRunner.Given("I enter to DSO page as superuser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 92
   testRunner.When("I click DSO claimant on DSO Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 93
        testRunner.Then("I see Add DSO Claimants header on Claimants page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 94
        testRunner.Then("I input \'LOUIS\' and I select debtorname \'12-32267 / LOUIS SCHOSSLER\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 95
        testRunner.Then("I input \'TEST\' and \'TEST\' and \'9505616939\' text fields information", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 96
     testRunner.Then("I input \'Both\' and \'AK\' and \'mpike\' and \'Sushma\' dropdown fields information", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 97
 testRunner.When("I select \'New Debtor Employer\' type", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 98
 testRunner.When("I select \'Individual\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 99
       testRunner.Then("I input Debtor title as \'Miss\' for \'Individual\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 100
    testRunner.Then("I input Debtor Firstname as \'Paul\' and MiddleName as \'Kristy\' and Lastname as \'BR" +
                    "AIN\' for \'Individual\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 101
 testRunner.When("I select \'New Joint Debtor Employer\' type", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 102
 testRunner.When("I select Joint debtor \'Corporation\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 103
 testRunner.When("I input Joint Debtor displayname as \'paul\' for \'Corporation\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 104
      testRunner.Then("I Save claimant", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 105
   testRunner.Then("I SignOut from the Unity Application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("008 - DSO Page-Add DSO claimant with only New Debtor-Corporation")]
        [NUnit.Framework.CategoryAttribute("DSOClaimsAdd")]
        [NUnit.Framework.CategoryAttribute("US226486")]
        public virtual void _008_DSOPage_AddDSOClaimantWithOnlyNewDebtor_Corporation()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("008 - DSO Page-Add DSO claimant with only New Debtor-Corporation", new string[] {
                        "DSOClaimsAdd",
                        "US226486"});
#line 109
 this.ScenarioSetup(scenarioInfo);
#line 110
 testRunner.Given("I enter to DSO page as superuser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 111
     testRunner.When("I click DSO claimant on DSO Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 112
      testRunner.Then("I see Add DSO Claimants header on Claimants page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 113
      testRunner.Then("I input \'17-90000\' and I select debtorname \'17-90000 / NareshRaj QATest1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 114
      testRunner.Then("I input \'Automation\' and \'TEST\' and \'9505616939\' text fields information", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 115
   testRunner.Then("I input \'Both\' and \'AL\' and \'mpike\' and \'Sushma\' dropdown fields information", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 116
  testRunner.When("I select \'New Debtor Employer\' type", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 117
  testRunner.When("I select \'Corporation\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 118
  testRunner.When("I input Debtor displayname as \'paul\' for \'Corporation\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 119
  testRunner.Then("I Save claimant", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 120
  testRunner.Then("I SignOut from the Unity Application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("009 - DSO Page-Verify Added Record -DSO claimant with only New Debtor-Corporation" +
            "")]
        [NUnit.Framework.CategoryAttribute("DSOClaimsAdd")]
        [NUnit.Framework.CategoryAttribute("US226486")]
        public virtual void _009_DSOPage_VerifyAddedRecord_DSOClaimantWithOnlyNewDebtor_Corporation()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("009 - DSO Page-Verify Added Record -DSO claimant with only New Debtor-Corporation" +
                    "", new string[] {
                        "DSOClaimsAdd",
                        "US226486"});
#line 124
 this.ScenarioSetup(scenarioInfo);
#line 125
 testRunner.Given("I enter to DSO page as superuser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 126
  testRunner.And("I see the Search box under All Cases Section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 127
  testRunner.When("I Enter \'17-90000\' On The Universal Search Section Input", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 128
  testRunner.And("I Click on the Case Result \'17-90000\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 129
     testRunner.Then("Verify the added record on Grid using climant name\'Automation\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 130
  testRunner.Then("I SignOut from the Unity Application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("010 - DSO Page-Verify Edit Record -DSO claimant with only New Debtor-Corporation")]
        [NUnit.Framework.CategoryAttribute("DSOClaimsEdit")]
        [NUnit.Framework.CategoryAttribute("US226487")]
        public virtual void _010_DSOPage_VerifyEditRecord_DSOClaimantWithOnlyNewDebtor_Corporation()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("010 - DSO Page-Verify Edit Record -DSO claimant with only New Debtor-Corporation", new string[] {
                        "DSOClaimsEdit",
                        "US226487"});
#line 134
 this.ScenarioSetup(scenarioInfo);
#line 135
 testRunner.Given("I enter to DSO page as superuser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 136
  testRunner.And("I see the Search box under All Cases Section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 137
  testRunner.When("I Enter \'17-90000\' On The Universal Search Section Input", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 138
  testRunner.And("I Click on the Case Result \'17-90000\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 139
  testRunner.Then("Verify the added record on Grid using climant name\'Automation\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 140
     testRunner.Then("input Edit fields information Address \'AutomationTest\' and Phone \'1234567890\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 141
  testRunner.Then("I Save claimant", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 142
  testRunner.Then("I SignOut from the Unity Application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("011 - DSO Page-Verify View Permission on DSO Page")]
        [NUnit.Framework.CategoryAttribute("View")]
        [NUnit.Framework.CategoryAttribute("DSO")]
        [NUnit.Framework.CategoryAttribute("Permission")]
        [NUnit.Framework.CategoryAttribute("US226487")]
        public virtual void _011_DSOPage_VerifyViewPermissionOnDSOPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("011 - DSO Page-Verify View Permission on DSO Page", new string[] {
                        "View",
                        "DSO",
                        "Permission",
                        "US226487"});
#line 146
 this.ScenarioSetup(scenarioInfo);
#line 147
 testRunner.Given("I enter to Unity Login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 148
 testRunner.When("I try to login with credentials vandita1, Welcome123Epiq! and crose", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 149
 testRunner.Given("I Go to DSO page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 150
 testRunner.Then("Verify for View icon symbol", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 151
  testRunner.Then("I SignOut from the Unity Application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
