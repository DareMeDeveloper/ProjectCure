using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpgradeMenuManager : MonoBehaviour
{
    [Header("Overall things for the upgrades")]
    public GameManager gameManager;
    public PollutionManager pollutionManager;
    public TextMeshProUGUI SliderText;
    public TextMeshProUGUI PopUpText;
    public GameObject PopUp;
    [Header("These are for the opening different pages")]
    public GameObject UpgradesForAir;
    public GameObject UpgradesForWater;

    public GameObject UpgradesForDeforestation;
    public void OpenAirPollutionPage()
    {
        //Opens the air pollution page
        UpgradesForAir.SetActive(true);
        UpgradesForWater.SetActive(false);
        UpgradesForDeforestation.SetActive(false);
    }
    public void OpenWaterPollutionPage()
    {
        //Switch
        UpgradesForAir.SetActive(false);
        UpgradesForWater.SetActive(true);
        UpgradesForDeforestation.SetActive(false);
    }
    public void Deforestation()
    {
        //Samething
        UpgradesForAir.SetActive(false);
        UpgradesForWater.SetActive(false);
        UpgradesForDeforestation.SetActive(true);
    }

    bool OpenedCarpooling = false;
    bool CPAlreadyBought = false;
    public void OpenCarPooling()
    {
        if (!CPAlreadyBought)
        {
            SliderText.text = "Reduce Greenhouse Gases!\n\nBike, walk, carpool, or use public transportation.";
        }
        else
        {
            SliderText.text = "Already applied this one.";
        }
        OpenedCarpooling = true;
        OpenedWaste = false;
        OpenedPaper = false;
        OpenedProduct = false;
        OpenedTobacco = false;
        OpenedReduceConsumptionMeat = false;
        OpenedAerosol = false;
        //Have every other Opened boolean set to false
    }

    bool OpenedReduceConsumptionMeat = false;
    bool ORCAlreadyBought = false;
    public void OpenReduceConsumption()
    {

        if (!OpenedReduceConsumptionMeat)
        {
            SliderText.text = "Reduce Methane, Save Land, and Decrease Water Contaminants!\n\nEat less Beef.";
        }
        else
        {
            SliderText.text = "Already applied this one.";
        }
        OpenedReduceConsumptionMeat = true;
        OpenedWaste = false;
        OpenedPaper = false;
        OpenedProduct = false;
        OpenedTobacco = false;
        OpenedCarpooling = false;
        OpenedAerosol = false;
        //Have every other Opened boolean set to false
    }
    bool OpenedAerosol = false;
    bool AAlreadyBought = false;
    public void OpenAerosol()
    {
        if (!AAlreadyBought)
        {
            SliderText.text = "Reduce Hydrocarbon Emissions and Hazardous Waste!\n\nAvoid Aerosols and Harsh Cleaning Products.";
        }
        else
        {
            SliderText.text = "Already applied this one.";
        }
        OpenedAerosol = true;
        OpenedWaste = false;
        OpenedPaper = false;
        OpenedProduct = false;
        OpenedTobacco = false;
        OpenedCarpooling = false;
        OpenedReduceConsumptionMeat = false;
        //Have every other Opened boolean set to false
    }


    bool OpenedTobacco = false;
    bool TAlreadyBought = false;
    public void OpenTobacco()
    {
        if (!TAlreadyBought)
        {
            SliderText.text = "Reduce Air Pollutants and Particulate Matter!\n\nReduce tobacco consumption!";
        }
        else
        {
            SliderText.text = "Already applied this one.";
        }
        OpenedTobacco = true;
        OpenedWaste = false;
        OpenedPaper = false;
        OpenedProduct = false;
        OpenedCarpooling = false;
        OpenedReduceConsumptionMeat = false;
        OpenedAerosol = false;
        //Have every other Opened boolean set to false
    }

    bool OpenedTrees = false;
    bool TreesAlreadyBought = false;
    public void OpenTrees()
    {
        if (!TreesAlreadyBought)
        {
            SliderText.text = "Improve Air Quality!\n\nPlant a tree.";
        }
        else
        {
            SliderText.text = "Already applied this one.";
        }
        OpenedTrees = true;
        OpenedWaste = false;
        OpenedPaper = false;
        OpenedProduct = false;
        OpenedTobacco = false;
        OpenedCarpooling = false;
        OpenedReduceConsumptionMeat = false;
        OpenedAerosol = false;
        //Have every other Opened boolean set to false
    }


    bool OpenedWaste = false;
    bool WasteAlreadyBought = false;
    public void OpenW()
    {
        if (!WasteAlreadyBought)
        {
            SliderText.text = "Help Clean Water!\n\nProperly dispose of Trash, Medicine, and Chemicals.";
        }
        else
        {
            SliderText.text = "Already apllied this one.";
        }
        OpenedWaste = true;
        OpenedPaper = false;
        OpenedProduct = false;
        OpenedTobacco = false;
        OpenedCarpooling = false;
        OpenedReduceConsumptionMeat = false;
        OpenedAerosol = false;
        //Have every other Opened boolean set to false
    }


    bool OpenedProduct = false;
    bool ProductAlreadyBought = false;
    public void OpenProdutuct()
    {
        if (!ProductAlreadyBought)
        {
            SliderText.text = "Reduce toxins in Water!\n\nUse Green Products.";
        }
        else
        {
            SliderText.text = "Already apllied this one.";
        }
        OpenedProduct = true;
        OpenedPaper = false;
        OpenedWaste = false;
        OpenedTobacco = false;
        OpenedCarpooling = false;
        OpenedReduceConsumptionMeat = false;
        OpenedAerosol = false;
        //Have every other Opened boolean set to false
    }

    bool OpenedPaper = false;
    bool PaperAlreadyBought = false;
    public void OpenPaper()
    {
        if (!PaperAlreadyBought)
        {
            SliderText.text = "Reduce usage of Paper Products!\n\nAvoid single use items. Go digital and buy used books.";
        }
        else
        {
            SliderText.text = "Already apllied this one.";
        }
        OpenedPaper = true;
        OpenedProduct = false;
        OpenedWaste = false;
        OpenedTobacco = false;
        OpenedCarpooling = false;
        OpenedReduceConsumptionMeat = false;
        OpenedAerosol = false;
        //Have every other Opened boolean set to false
    }


    public bool isBuying = false;
    public void BuyAnUpgrade()
    {
        //upgrade 1
        if (!CPAlreadyBought && OpenedCarpooling && gameManager.GovermentFunding >= 50)
        {
            PopUp.SetActive(true);
            PopUpText.text = "Great, clean air!\n\nLung Diseases and Asthma have been reduced.";
            SliderText.text = "Already have bought this one.";
            pollutionManager.PollutionAmount -= 500;
            gameManager.GovermentFunding -= 50;
            CPAlreadyBought = true;
            isBuying = true;
        }
        else
        {
            SliderText.text = "Already have bought this one.";
        }
        //upgrade 1
        if (!ORCAlreadyBought && OpenedReduceConsumptionMeat && gameManager.GovermentFunding >= 50)
        {
            PopUp.SetActive(true);
            PopUpText.text = "Ozone Protected!\n\nDecline in premature respiratory deaths.";
            SliderText.text = "Already have bought this one.";
            pollutionManager.PollutionAmount -= 500;
            gameManager.GovermentFunding -= 50;
            ORCAlreadyBought = true;
            isBuying = true;
        }
        else
        {
            SliderText.text = "Already have bought this one.";
        }
        if (!AAlreadyBought && OpenedAerosol && gameManager.GovermentFunding >= 50)
        {
            PopUp.SetActive(true);
            PopUpText.text = "Ambient air pollution reduced!\n\nLives saved!";
            SliderText.text = "Already have bought this one.";
            pollutionManager.PollutionAmount -= 500;
            gameManager.GovermentFunding -= 50;
            AAlreadyBought = true;
            isBuying = true;
        }
        else
        {
            SliderText.text = "Already have bought this one.";
        }

        if (!TAlreadyBought && OpenedTobacco && gameManager.GovermentFunding >= 50)
        {
            PopUp.SetActive(true);
            PopUpText.text = "Breathe better!\n\nAsthma symptoms improved.";
            SliderText.text = "Already have bought this one.";
            pollutionManager.PollutionAmount -= 500;
            gameManager.GovermentFunding -= 50;
            TAlreadyBought = true;
            isBuying = true;
        }
        else
        {
            SliderText.text = "Already have bought this one.";
        }

        if (!TreesAlreadyBought && OpenedTrees && gameManager.GovermentFunding >= 50)
        {
            PopUp.SetActive(true);
            PopUpText.text = "Air Quality Improved!";
            SliderText.text = "Already have bought this one.";
            pollutionManager.PollutionAmount -= 500;
            gameManager.GovermentFunding -= 50;
            TreesAlreadyBought = true;
            isBuying = true;
        }
        else
        {
            SliderText.text = "Already have bought this one.";
        }

        if (!WasteAlreadyBought && OpenedWaste && gameManager.GovermentFunding >= 50)
        {
            PopUp.SetActive(true);
            PopUpText.text = "Decline in diarrheal diseases like Cholera!\nE. Coli, Salmonella, and Hepatitis exposure reduced!";
            SliderText.text = "Already have bought this one.";
            pollutionManager.PollutionAmount -= 500;
            gameManager.GovermentFunding -= 50;
            WasteAlreadyBought = true;
            isBuying = true;
        }
        else
        {
            SliderText.text = "Already have bought this one.";
        }

        if (!ProductAlreadyBought && OpenedProduct && gameManager.GovermentFunding >= 50)
        {
            PopUp.SetActive(true);
            PopUpText.text = "Clean Water!\n\nWater toxins reduced.";
            SliderText.text = "Already have bought this one.";
            pollutionManager.PollutionAmount -= 500;
            gameManager.GovermentFunding -= 50;
            ProductAlreadyBought = true;
            isBuying = true;
        }
        else
        {
            SliderText.text = "Already have bought this one.";
        }

        if (!PaperAlreadyBought && OpenedPaper && gameManager.GovermentFunding >= 50)
        {
            PopUp.SetActive(true);
            PopUpText.text = "Lives Saved! Reduce the risk of exposure to UNKNOWN HUMAN DISEASES.";
            SliderText.text = "Already have bought this one.";
            pollutionManager.PollutionAmount -= 500;
            gameManager.GovermentFunding -= 50;
            PaperAlreadyBought = true;
            isBuying = true;
        }
        else
        {
            SliderText.text = "Already have bought this one.";
        }



    }
    public void closePopUp1()
    {
        PopUp.SetActive(false);
        OpenedCarpooling = false;
    }
}
