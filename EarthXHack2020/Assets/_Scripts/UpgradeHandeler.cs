using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpgradeHandeler : MonoBehaviour
{
    [Header("Text for other upgrade menu")]
    public TextMeshProUGUI OtherupgradeText1;
    public TextMeshProUGUI OtherupgradeText2;
    [Header("Text for regular upgrade menu")]
    public TextMeshProUGUI upgradeText3;
    public TextMeshProUGUI upgradeText4;
    GameManager manager;
    PollutionManager Pm;
    void Awake()
    {
        manager = GetComponent<GameManager>();
        Pm = GetComponent<PollutionManager>();

    }


    [Header("Upgrade Options for Faster Earning Multiplier")]
    //Upgrade 1
    int MaxUpgrade = 4;
    int upgraded = 0;
    bool hitMaxFasterMoneyUpgrade = false;
    public int CostForFasterEarning = 50;
    public void BuyFasterMoneyEaring()
    {
        if (manager.GovermentFunding >= CostForFasterEarning && upgraded <= MaxUpgrade)
        {
            manager.GovermentFunding -= CostForFasterEarning;
            manager.FundingMultiplier *= 2f;
            upgraded += 1;
            CostForFasterEarning *= 2;
        }
    }

    //Upgrade 2
    [Header("Upgrade Options to lower pollution rates")]
    int MaxUpgradeFLPR = 15;
    int upgradedFLPR = 0;
    bool hitMaxUpgradeForLPR = false;
    public int CostForLPR = 50;
    public void LowerPollutionRates()
    {
        if (manager.GovermentFunding >= CostForLPR && upgradedFLPR <= MaxUpgradeFLPR)
        {
            Pm.PollutionRate -= 10f;
            manager.GovermentFunding -= CostForLPR;
            upgradedFLPR += 1;
            CostForLPR *= 2;
        }
    }

    //Upgrade 3
    [Header("Upgrade Options for Advertising to get more People")]
    public int CostForAPE = 50;
    public void AddPeopleEffort()
    {
        if (manager.GovermentFunding >= CostForAPE)
        {
            manager.Efforts += 100;
            manager.GovermentFunding -= CostForAPE;
            CostForAPE *= 2;
        }
    }

    //Upgrade 4
    [Header("Upgrade Options for Faster People Effort Multiplier")]
    int MaxUpgradeFAPEM = 3;
    int upgradedFAPEM = 0;
    bool hitMaxUpgradeForFAPEM = false;
    public int CostForAPEM = 50;

    public void AddPeopleEffortMultiplier()
    {
        if (manager.GovermentFunding >= CostForAPEM && upgradedFAPEM <= MaxUpgradeFAPEM)
        {
            manager.EffortMultiplier *= 2f;
            manager.GovermentFunding -= CostForAPEM;
            upgradedFAPEM += 1;
            CostForAPEM *= 2;
        }
    }

    void Update()
    {
        PrintText();
    }
    void PrintText()
    {
        //Upgrade 1
        if (upgraded >= MaxUpgrade)
        {
            hitMaxFasterMoneyUpgrade = true;
        }
        if (hitMaxFasterMoneyUpgrade == false)
        {
            OtherupgradeText1.text = "Buy faster earning for " + CostForFasterEarning.ToString() + "k";
        }
        else
        {
            OtherupgradeText1.text = "Max upgrade";
        }
        //Upgrade 2
        if (upgradedFLPR >= MaxUpgradeFLPR)
        {
            hitMaxUpgradeForLPR = true;
        }
        if (hitMaxUpgradeForLPR == false)
        {
            OtherupgradeText2.text = "Lower pollution by 10. Current rate: " + Pm.PollutionRate.ToString() + " for " + CostForLPR + "k";
        }
        else
        {
            OtherupgradeText2.text = "Max upgrade";
        }

        //Upgrade 3

        upgradeText3.text = "Advertise for more followers for: " + CostForAPE.ToString() + "k";

        //Upgrade 4

        if (upgradedFAPEM >= MaxUpgradeFAPEM)
        {
            hitMaxUpgradeForFAPEM = true;
        }
        if (hitMaxUpgradeForFAPEM == false)
        {
            upgradeText4.text = "Increase follower sharing for: " + CostForAPEM.ToString() + "k";
        }
        else
        {
            upgradeText4.text = "Max upgrade";
        }
    }
}
