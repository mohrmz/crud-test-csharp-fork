﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Mc2.CrudTest.AcceptanceTests.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class CustomerManagerFeature : object, Xunit.IClassFixture<CustomerManagerFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "CustomerManager.feature"
#line hidden
        
        public CustomerManagerFeature(CustomerManagerFeature.FixtureData fixtureData, Mc2_CrudTest_AcceptanceTests_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "CustomerManager", @"	As a customer management system (CMS) 
	I want to store customer contact information included firstname, lastname, dateofbirth, email, bankaccountnumber and phonenumber validated with LibPhoneNumber and a valid email and a bank account number with unique Email and a customer with unique Firstname, Lastname and DateOfBirth in database
	So that i have an accurate information from customers and have simple crud customer model", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
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
#line 7
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "FirstName",
                        "LastName",
                        "DateOfBirth",
                        "PhoneNumber",
                        "Email",
                        "BankAccountNumber"});
            table1.AddRow(new string[] {
                        "Mohammad",
                        "Ramezani",
                        "1995-05-05",
                        "+441174960123",
                        "mohammad0ramezani@gmail.com",
                        "DE12345678901234567890"});
#line 8
 testRunner.Given("The Valid Customer Has Following Information", ((string)(null)), table1, "Given ");
#line hidden
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="1) Create A New Valid Customer")]
        [Xunit.TraitAttribute("FeatureTitle", "CustomerManager")]
        [Xunit.TraitAttribute("Description", "1) Create A New Valid Customer")]
        [Xunit.TraitAttribute("Category", "createapi")]
        public virtual void _1CreateANewValidCustomer()
        {
            string[] tagsOfScenario = new string[] {
                    "createapi"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("1) Create A New Valid Customer", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 13
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
#line 7
this.FeatureBackground();
#line hidden
#line 14
 testRunner.When("I Want To Register A New Valid Customer In CMS", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 15
 testRunner.Then("The Customer With Correct Information Should Be Added In DB", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="2) Create A New Customer With Invalid Phone Number")]
        [Xunit.TraitAttribute("FeatureTitle", "CustomerManager")]
        [Xunit.TraitAttribute("Description", "2) Create A New Customer With Invalid Phone Number")]
        [Xunit.TraitAttribute("Category", "createapi")]
        public virtual void _2CreateANewCustomerWithInvalidPhoneNumber()
        {
            string[] tagsOfScenario = new string[] {
                    "createapi"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("2) Create A New Customer With Invalid Phone Number", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 18
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
#line 7
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                            "FirstName",
                            "LastName",
                            "DateOfBirth",
                            "PhoneNumber",
                            "Email",
                            "BankAccountNumber"});
                table2.AddRow(new string[] {
                            "MohammadPhon",
                            "Ramezani",
                            "1995-05-05",
                            "1174960123",
                            "mohammadramezani@gmail.com",
                            "DE12345678901234567890"});
#line 19
 testRunner.Given("The Invalid Phone Number Customer Has Following Information", ((string)(null)), table2, "Given ");
#line hidden
#line 22
 testRunner.When("I Want To Register A New Customer With Invalid Phone Number In CMS", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 23
 testRunner.Then("The Invalid Phone Number Customer Should Not Be Added In DB And Raise Error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="3) Create A New Customer With Invalid Email")]
        [Xunit.TraitAttribute("FeatureTitle", "CustomerManager")]
        [Xunit.TraitAttribute("Description", "3) Create A New Customer With Invalid Email")]
        [Xunit.TraitAttribute("Category", "createapi")]
        public virtual void _3CreateANewCustomerWithInvalidEmail()
        {
            string[] tagsOfScenario = new string[] {
                    "createapi"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("3) Create A New Customer With Invalid Email", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 26
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
#line 7
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                            "FirstName",
                            "LastName",
                            "DateOfBirth",
                            "PhoneNumber",
                            "Email",
                            "BankAccountNumber"});
                table3.AddRow(new string[] {
                            "Mohammadma",
                            "Ramezani",
                            "1995-05-05",
                            "+441174960123",
                            "mohammad0ramezani",
                            "DE12345678901234567890"});
#line 27
 testRunner.Given("The Invalid Email Customer Has Following Information", ((string)(null)), table3, "Given ");
#line hidden
#line 30
 testRunner.When("I Want To Register A New Customer With Invalid Email In CMS", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 31
 testRunner.Then("The Invalid Email Customer Customer Should Not Be Added In DB And Raise Error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="4) Create A New Customer With Invalid Bank Account Number")]
        [Xunit.TraitAttribute("FeatureTitle", "CustomerManager")]
        [Xunit.TraitAttribute("Description", "4) Create A New Customer With Invalid Bank Account Number")]
        [Xunit.TraitAttribute("Category", "createapi")]
        public virtual void _4CreateANewCustomerWithInvalidBankAccountNumber()
        {
            string[] tagsOfScenario = new string[] {
                    "createapi"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("4) Create A New Customer With Invalid Bank Account Number", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 34
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
#line 7
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                            "FirstName",
                            "LastName",
                            "DateOfBirth",
                            "PhoneNumber",
                            "Email",
                            "BankAccountNumber"});
                table4.AddRow(new string[] {
                            "Mohammadban",
                            "Ramezani",
                            "1995-05-05",
                            "+441174960123",
                            "mohammad12ramezani@gmail.com",
                            "213"});
#line 35
 testRunner.Given("The Invalid Bank Account Number  Customer Has Following Information", ((string)(null)), table4, "Given ");
#line hidden
#line 38
 testRunner.When("I Want To Register A New Customer With Invalid Bank Account Number In CMS", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 39
 testRunner.Then("The Invalid Bank Account Number Customer Should Not Be Added In DB And Raise Erro" +
                        "r", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="5) Read Customer")]
        [Xunit.TraitAttribute("FeatureTitle", "CustomerManager")]
        [Xunit.TraitAttribute("Description", "5) Read Customer")]
        [Xunit.TraitAttribute("Category", "readapi")]
        public virtual void _5ReadCustomer()
        {
            string[] tagsOfScenario = new string[] {
                    "readapi"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("5) Read Customer", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 42
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
#line 7
this.FeatureBackground();
#line hidden
#line 43
 testRunner.When("I Want To Manage Customers", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 44
 testRunner.Then("The Customers Should Be Loaded From DB", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="6) Update Customer")]
        [Xunit.TraitAttribute("FeatureTitle", "CustomerManager")]
        [Xunit.TraitAttribute("Description", "6) Update Customer")]
        [Xunit.TraitAttribute("Category", "updateapi")]
        public virtual void _6UpdateCustomer()
        {
            string[] tagsOfScenario = new string[] {
                    "updateapi"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("6) Update Customer", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 47
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
#line 7
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                            "FirstName",
                            "LastName",
                            "DateOfBirth",
                            "PhoneNumber",
                            "Email",
                            "BankAccountNumber"});
                table5.AddRow(new string[] {
                            "MohammadTest",
                            "Ramezani",
                            "1995-05-05",
                            "+441174960123",
                            "mohammadramezani@gmail.com",
                            "DE12345678901234567890"});
#line 48
 testRunner.Given("The Customer Information Update To the Following Information", ((string)(null)), table5, "Given ");
#line hidden
#line 51
 testRunner.When("I Want To update Customer Information In CMS", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 52
 testRunner.Then("The Customer Information Should Be Updated In DB", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="7) Delete Customer")]
        [Xunit.TraitAttribute("FeatureTitle", "CustomerManager")]
        [Xunit.TraitAttribute("Description", "7) Delete Customer")]
        [Xunit.TraitAttribute("Category", "deleteapi")]
        public virtual void _7DeleteCustomer()
        {
            string[] tagsOfScenario = new string[] {
                    "deleteapi"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("7) Delete Customer", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 55
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
#line 7
this.FeatureBackground();
#line hidden
#line 56
 testRunner.When("I Want To Delete Customer Information In CMS", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 57
 testRunner.Then("The Customer Information Should Be Deleted From DB And Load Empty", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                CustomerManagerFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                CustomerManagerFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
