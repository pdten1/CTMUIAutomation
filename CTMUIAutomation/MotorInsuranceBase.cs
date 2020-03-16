using CTMUIAutomation.Context;
using CTMUIAutomation.Pages;
using CTMUIAutomation.Pages.Motor;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTMUIAutomation
{
    public class MotorInsuranceBase
    {
        CTMLandingPage landingPage;
        CarInsurancePage carInsurancePage;
        P01_StartPage startPage;
        P02_RegoState regoState;
        P03_CoverType coverType;
        P04_FactoryOptions factoryOptions;
        P04a_StandardOptions standardOptions;
        P04b_NonStandardOptions nonStandardOptions;
        P05_Modifications modifications;
        P06_HailDamage hailDamage;
        P07_Finance finance;
        P08_UseType useType;
        P08a_PassengerPayment passengerPayment;
        P08b_GoodsPayment goodPayment;
        P09_AnnualKM annualKM;
        P10_CarAddress carAddress;
        P11_OvernightParking overnightParking;
        P12_DriverGender driverGender;
        P13_DriverDOB driverDOB;
        P14_DriverEmployment driverEmployment;
        P15_DriverLicenceAge driverLicenceAge;
        P16_DriverClaims driverClaims;
        P17_DriverNCD driverNCD;
        P18_DriverOwnsAnotherCar driverOwnAnorherCar;
        P19_YoungestDriver youngestDriver;
        P19a_YoungestDriverGender youngestDriverGender;
        P19b_YoungestDriverAge youngestDriverAge;
        P19c_YoungestDriverLicenceAge youngestDriverLicenceAge;
        P20_DriverOption driverOptions;
        P20_ApplicantDetails applicantDetails;
        P21_CommencementDate commencementDate;
        public P22_Results results;

        public void StartMotorQuote()
        {

            landingPage =  new CTMLandingPage();
            landingPage.SelectProductToCompare("Car Insurance");

            Console.WriteLine("\t Starting a car insurance quote");
            carInsurancePage = new CarInsurancePage();
            carInsurancePage.StartCarQuote();
        }
        public void CompleteMotorQuotes(string cover, string factoryOps, string carUsage, string hasyoungestDriver)
        {
            startPage = new P01_StartPage();
            regoState = startPage.EnterPageData("AP47PM");
            coverType = regoState.SelectState("NSW");
            factoryOptions = coverType.SelectCoverType(cover);

            factoryOptions.EnterPageData(factoryOps);
            if (factoryOps.Trim().ToLower() == "no")
            {
                modifications = new P05_Modifications();
            }
            else
            {
                standardOptions = new P04a_StandardOptions();
                nonStandardOptions = standardOptions.SelectStandardOptions(new string[] { "16\" Alloy Wheels", "Paint - Metallic" });
                modifications = nonStandardOptions.EnterNonStandardOptions(new string[] { "Airbag", "Air Conditioner" });
            }

            hailDamage = modifications.HasModifications("yes");
            finance = hailDamage.HasHailDamage("no");
            useType = finance.EnterPageData("finance");
            useType.EnterPageData(carUsage);
            if (carUsage.Trim().ToLower() == "private")
            {
                annualKM = new P09_AnnualKM();
            }
            else
            {
                passengerPayment = new P08a_PassengerPayment();
                goodPayment = passengerPayment.UsedForCarryPassengers("no");
                annualKM = goodPayment.UsedForCarryGoods("no");
            }

            carAddress = annualKM.EnterPageData("5000");
            overnightParking = carAddress.EnterPageData("2117", "27 kissing point road, dundas");

            driverGender = overnightParking.SelectCarParked("car park");
            driverDOB = driverGender.SetDriverGender("male");
            driverEmployment = driverDOB.EnterDriverDOB("25 Nov 1981");
            driverLicenceAge = driverEmployment.SelectEmployment("employed part time");
            driverClaims = driverLicenceAge.EnterLicenceAge("30");
            driverNCD = driverClaims.HasClaims("no");
            driverOwnAnorherCar = driverNCD.SelectNCD("RATING 6");

            youngestDriver = driverOwnAnorherCar.HasAnotherCar("yes");
            youngestDriver.SetyoungestDriver(hasyoungestDriver);
            if (hasyoungestDriver.Trim().ToLower() == "yes")
            {
                youngestDriverGender = new P19a_YoungestDriverGender();
                youngestDriverAge = youngestDriverGender.SetYoungestDriverGender("female");
                youngestDriverLicenceAge = youngestDriverAge.EnterYoungestDriverDOB("15-FEB-2002");

                applicantDetails = youngestDriverLicenceAge.EnterLicenceAge("18");
            }
            else
            {
                driverOptions = new P20_DriverOption();
                applicantDetails = driverOptions.SelectDriverOption("NO restrictions");
            }

            commencementDate = applicantDetails.EnterApplicantDetails("James", "Bond", "0432111222", "pub@hotmail.com");
            results = commencementDate.SelectCommencementDate("18/03/2020");

        }

    }
}
