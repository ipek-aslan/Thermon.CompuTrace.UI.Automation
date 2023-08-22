using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Spreadsheet;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.Assist;
using Thermon.CompuTrace.UI.Automation.Hook;
using Thermon.CompuTrace.UI.Automation.Utilities;
using Thermon.CompuTrace.UI.Automation.Utils;
using Table = TechTalk.SpecFlow.Table;

namespace Thermon.CompuTrace.UI.Automation.StepDefinitions
{
    [Binding]
    public class AdvanceConfigurationSteps
    {
        ScenarioContext _scenarioContext;
        public AdvanceConfigurationSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        //Templates for Custom BoM Entries

        [When(@"I click on Add Item button")]
        public void WhenIClickOnAddItemButton()
        {
            IWebElement addItemButton = Driver.Instance.FindElement(By.XPath("//button[@aria-label=('Add Item')]"));
            addItemButton.Click();
        }


        [When(@"I click on Add Item button on project level custom components")]
        public void WhenIClickOnAddItemButtonOnProjectLevelComponents()
        {
            IWebElement addItemButton = Driver.Instance.FindElement(By.XPath("//button[contains(text(),'Add item')]"));
            addItemButton.Click();
        }


        [When(@"I enter catalog number '([^']*)'")]
        public void WhenIEnterCatalogNumber(string catalogNumber)
        {

            IWebElement catalogNumberInput = Driver.Instance.FindElement(By.XPath("//input[@name='catalogNumber']"));
            catalogNumberInput.Click();
            catalogNumberInput.SendKeys(catalogNumber);

        }


        [When(@"I enter part number '([^']*)'")]
        public void WhenIEnterPartNumber(string partNumber)
        {
            IWebElement partNumberInput = Driver.Instance.FindElement(By.XPath("//input[@name='partNumber']"));
            partNumberInput.Click();
            partNumberInput.SendKeys(partNumber);
        }

        
        [When(@"I click on add button")]
        public void WhenIClickAddButton()
        {
            IWebElement addButton = Driver.Instance.FindElement(By.XPath("//button[text()='Add']"));
            addButton.Click();
        }


        [Then(@"I should be able to see item added on Templates For Custom BoM Entries page")]
        public void ThenIShouldBeAbleToSeeItemAddedOnTemplatesForCustomBoMEntriesPage()
        {
            List<IWebElement> addedItemElement = Driver.Instance.FindElements(By.XPath("(//div[contains(@class,'MuiDataGrid-virtualScrollerRenderZone')])[2]//div[@role='row']")).ToList();
            Assert.True(addedItemElement.Count.Equals(_scenarioContext["itemsCount"]),"All items are not added");
        }


        // Project Level Miscellaneous Defaults

        [When(@"I click on Next button on Templates For Custom BoM Entries page")]
        public void WhenIClickOnNextButtonOnTemplatesForCustomBoMEntriesPage()
        {
            IWebElement nextButton = Driver.Instance.FindElement(By.XPath("//button[contains(text(),'Next')]"));
            nextButton.Click();
        }


        [When(@"I select Controller Type")]
        public void WhenISelectControllerType(Table table)
        {
            var ControllerTable = table.CreateInstance<AdvanceConfiguration>();
            IWebElement ControllerType = Driver.Instance.FindElement(By.XPath("//input[@value='"+ControllerTable.ControllerType+"']"));
            _scenarioContext.Add("ControllerType", ControllerTable.ControllerType);
            ControllerType.Click();

        }


        [Then(@"I should be able to see selected controller type")]
        public void ThenIShouldBeAbleToSeeMechanicalThermostat()
        {
            IWebElement ControllerType = Driver.Instance.FindElement(By.XPath("//input[@value='" + _scenarioContext["ControllerType"] + "']"));
            Assert.True(ControllerType.Selected,"Not able to select Controller Type");
        }


        //Project Level Custom Components

        [When(@"I click on Next button on  Project Level Miscellaneous Defaults page")]
        public void WhenIClickOnNextButtonOnProjectLevelMiscellaneousDefaultsPage()
        {
            IWebElement nextButton = Driver.Instance.FindElement(By.XPath("//button[contains(text(),'Next')]"));
            nextButton.Click();
        }


        [When(@"I Add new items on Templates For project level custom components")]
        public void WhenIAddNewItemsOnTemplatesForProjectLevelCustomComponents(Table table)
        {
            var entries = table.CreateSet<AdvanceConfiguration>();

            var Count = entries.Count<AdvanceConfiguration>();
            _scenarioContext.Add("itemsCount", Count);
            foreach (AdvanceConfiguration item in entries)
            {

                WhenIClickOnAddItemButtonOnProjectLevelComponents();
                WhenISelectComponentTypeFromDropdown(item.componenttype);
                Thread.Sleep(3000);
                WhenIEnterCatalogNumber(item.catalognumber);
                WhenIEnterPartNumber(item.partnumber);
                WhenIClickAddButton();

            }
        }


        [When(@"I select component type from dropdown")]
        public void WhenISelectComponentTypeFromDropdown(string componentType)
        {
            Driver.Instance.FindElement(By.XPath("//div[@id='mui-component-select-componentTypes']")).Click();
            List<IWebElement> listbox = Driver.Instance.FindElements(By.XPath("//div[@id='menu-componentTypes']//ul/li")).ToList();
            foreach (var element in listbox)
            {
                if (element.Text.Contains(componentType))
                {
                    element.FindElement(By.XPath("//div[@id='menu-componentTypes']//ul/li[contains(text(),'" + componentType + "')]")).Click();
                    break;
                }
            }
        }



        [When(@"I select component type from dropdown on project extra requirements page")]
        public void WhenISelectComponentTypeFromDropdownOnProjectExtraRequirementsPage(string componentType)
        {
            Driver.Instance.FindElement(By.XPath("//label[contains(text(),'Select New')]/..//div[contains(@class,'MuiSelect-select MuiSelect-outlined')]")).Click();
            List<IWebElement> listbox = Driver.Instance.FindElements(By.XPath("//ul[contains(@class,'MuiMenu-list')]//li")).ToList();
            foreach (var element in listbox)
            {
                if (element.Text.Contains(componentType))
                {
                    element.FindElement(By.XPath("//ul[contains(@class,'MuiMenu-list')]//li//div/span[text()='"+ componentType+"']")).Click();
                    break;
                }
            }
        }


        [When(@"I select catalog part from dropdown on project extra requirements page")]
        public void WhenISelectCatalogPartFromDropdownOnProjectExtraRequirementsPage(int rowCount,string catalogPart)
        {
            Driver.Instance.FindElement(By.XPath("(//div[@role='row']//div[contains(@class,'MuiSelect-select')])["+rowCount+"]")).Click();
            List<IWebElement> listbox = Driver.Instance.FindElements(By.XPath("//ul[contains(@class,'MuiMenu-list')]//li")).ToList();
            foreach (var element in listbox)
            {
                if (element.Text.Contains(catalogPart))
                {
                    element.FindElement(By.XPath("//ul[contains(@class,'MuiMenu-list')]//li//div/span[text()='" + catalogPart + "']")).Click();
                    break;
                }
            }
        }


        [When(@"I Add new items on Templates For Custom BoM Entries page")]
        public void WhenIAddNewItemsOnTemplatesForCustomBoMEntriesPage(Table table)
        {
            var entries = table.CreateSet<AdvanceConfiguration>();

            var Count = entries.Count<AdvanceConfiguration>();
            _scenarioContext.Add("itemsCount", Count);
            foreach (AdvanceConfiguration item in entries)
            {
                WhenIClickOnAddItemButton();
                WhenIEnterCatalogNumber(item.catalognumber);
                WhenIEnterPartNumber(item.partnumber);
                WhenIClickAddButton();

            } 
        }


        [Then(@"I should be able to see item added on Project Level Custom Components Page")]
        public void ThenIShouldBeAbleToSeeItemAddedOnProjectLevelCustomComponentsPage()
        {
            List<IWebElement> addedItemElement = Driver.Instance.FindElements(By.XPath("(//div[contains(@class,'MuiDataGrid-virtualScrollerRenderZone')])[2]//div[@role='row']")).ToList();
            Assert.True(addedItemElement.Count.Equals(_scenarioContext["itemsCount"]), "All items are not added");
        }



        //Project Extra Requirements

        [When(@"I click on Next button on Project Level Custom Components page")]
        public void WhenIClickOnNextButtonOnProjectLevelCustomComponentsPage()
        {
            IWebElement nextButton = Driver.Instance.FindElement(By.XPath("//button[contains(text(),'Next')]"));
            nextButton.Click();
        }



        [When(@"I select component type on Project Extra Components page")]
        public void WhenISelectComponentTypeOnProjectExtraComponentsPage(Table table)
        {
            var component = table.CreateInstance<AdvanceConfiguration>();
            WhenISelectComponentTypeFromDropdownOnProjectExtraRequirementsPage(component.componenttype);
        }



        [When(@"I select catalog part from dropdown")]
        public void WhenISelectCatalogPartFromDropdown()
        {
            IWebElement catalogDropdown = Driver.Instance.FindElement(By.Id("catalogDropdown"));
            var selectElement = new SelectElement(catalogDropdown);
            selectElement.SelectByText("Catalog Part"); 
        }



        [When(@"I select Catalog Part from dropdown on Project Extra Components page")]
        public void WhenISelectCatalogPartFromDropdownOnProjectExtraComponentsPage(Table table)
        {
            var entries = table.CreateSet<AdvanceConfiguration>();

            var Count = entries.Count<AdvanceConfiguration>();
            int rowCount = 1;
            _scenarioContext.Add("itemsCount", Count);
            foreach (AdvanceConfiguration item in entries)
            {
                WhenISelectCatalogPartFromDropdownOnProjectExtraRequirementsPage(rowCount, item.CatalogPart);
                Thread.Sleep(3000);
                if (rowCount < Count)
                {
                    Driver.Instance.FindElement(By.XPath("//button[contains(text(),'Add component')]")).Click();
                }
                rowCount++;
            }
        }


        [Then(@"I should be able to see component type and catalog part added")]
        public void ThenIShouldBeAbleToComponentTypeAndCatalogPartAdded()
        {
            List<IWebElement> addedItemElement = Driver.Instance.FindElements(By.XPath("//div[@role='row']//div[contains(@class,'MuiSelect-select')]")).ToList();
            Assert.True(addedItemElement.Count.Equals(_scenarioContext["itemsCount"]), "All items are not added");
        }


        //Project Available Components

        [When(@"I click on Next button on Project Extra Requirements page")]
        public void WhenIClickOnNextButtonOnProjectExtraRequirementsPage()
        {
            IWebElement nextButton = Driver.Instance.FindElement(By.XPath("//button[contains(text(),'Next')]"));
            nextButton.Click();
        }



        [When(@"I select component type from lists to add to available components")]
        public void WhenISelectComponentTypeFromListsToAddToAvailableComponents()
        {
           List<String> availableComponents = new List<String>() { "PowerConnection","Splice","Controller","Tape","Label","Banding","EndSeal","Sensor"};
            int count = 0;
            foreach (var component in availableComponents)
            {               
                IWebElement componentType= Driver.Instance.FindElement(By.XPath("//h6[contains(text(),'"+component+"')]/..//following-sibling::div//button[@aria-label='Add to available components']"));
                if (count >= availableComponents.Count/2)
                {
                    TestUtilities.ScrollToElement(Driver.Instance.FindElement(By.XPath("//h6[contains(text(),'" + component + "')]")));
                    Thread.Sleep(1000);
                    componentType.Click();
                }
                else { componentType.Click(); }
                count++;
                Thread.Sleep(1000);

            }
        }

        [Then(@"I should be able to see component type added")]
        public void ThenIShouldBeAbleToSeeComponentTypeAdded()
        {
            List<String> availableComponents = new List<String>() { "PowerConnection", "Splice", "Controller", "Tape", "Label", "Banding", "EndSeal", "Sensor" };

            foreach (var component in availableComponents)
            { IWebElement componentType = Driver.Instance.FindElement(By.XPath("//h6[contains(text(),'" + component + "')]/..//following-sibling::div//button[@aria-label='Return to restricted components']"));
                //TestUtilities.ScrollToElement(componentType);
                Assert.True(componentType.Displayed, "Failed to add component type in add to avaialable components") ;

            }
        }


        //Project Tag Defaults

        [When(@"I click on Next button on Project Available Components page")]
        public void WhenIClickOnNextButtonOnProjectAvailableComponentsPage()
        {
            IWebElement nextButton = Driver.Instance.FindElement(By.XPath("//button[contains(text(),'Next')]"));
            nextButton.Click();
        }


        [When(@"I click use default button")]
        public void WhenIClickUseDefaultButton()
        {
            IWebElement useDefaultButton = Driver.Instance.FindElement(By.XPath("//button[contains(text(),'Use Defaults')]"));
            useDefaultButton.Click();

        }

        [Then(@"I should be able to see Project Tag Defaults added")]
        public void ThenIShouldBeAbleToSeeProjectTagDefaultsAdded()
        {
            var ThermonDrawing = Driver.Instance.FindElement(By.XPath("//span[contains(text(),'Thermon Drawing')]/../following-sibling::div//span[contains(@class,'MuiTypography-root')]"));
            Assert.True(ThermonDrawing.Text != string.Empty || ThermonDrawing.Text != null, "Thermon Drawing field is blank");     
        }


        //Circuit Reference Drawing List

        [When(@"I click on Next button on Project Tag Defaults page")]
        public void WhenIClickOnNextButtonOnProjectTagDefaultsPage()
        {
            IWebElement nextButton = Driver.Instance.FindElement(By.XPath("//button[contains(text(),'Next')]"));
            nextButton.Click();
        }


        //import file
        [When(@"I click Import Circuit Reference Drawing Type button")]
        public void WhenIClickImportCircuitReferenceDrawingTypeButton()
        {
            IWebElement fileInput = Driver.Instance.FindElement(By.Id("raised-button-file-Import Circuit Reference Drawing Type")); // Replace "file-upload" with the actual ID or other locator of the file input element
            string filePath = @"C:\Users\iarslanbas\Desktop\Cairo\Thermon.CompuTrace.UI.Automation\Import_ExportFile\CircuitREferenceDrawings.xlsx"; // Replace with the actual file path
            fileInput.SendKeys(filePath);
            Thread.Sleep(5000);
            //IWebElement submitButton = Driver.Instance.FindElement(By.Id("submit-button")); // Replace "submit-button" with the ID or locator of the submit button
            //submitButton.Click(); // Click the submit button to initiate the file upload process

        }

        //import circuit reference drawing type clicking
        //file should be added 

        [Then(@"I should be able to see Circuit Reference Drawing List")]
        public void ThenIShouldBeAbleToSeeCircuitReferenceDrawingList()
        {
            List<IWebElement> circuitReferenceListElement = Driver.Instance.FindElements(By.XPath("//div[@data-field='referenceDrawingType']")).ToList();
            Assert.True(circuitReferenceListElement.Count>=2,"Circuit Reference Drawing file is not uploaded");
        }

    }
}
