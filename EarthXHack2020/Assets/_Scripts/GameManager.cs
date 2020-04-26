using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    public float TimeBetweenEfforts;
    private float EffortTime;
    public float Efforts;

    public float EffortMultiplier;
    public TextMeshProUGUI EffortText;

    public float TimebetweenFunding;
    private float fundingTime;
    public float GovermentFunding;
    public TextMeshProUGUI GovernmentFundingText;

    public float FundingMultiplier;
    // Update is called once per framesta
    void Start()
    {
        FundingMultiplier = Efforts;
    }
    void Update()
    {
        EffortTime += Time.deltaTime;
        fundingTime += Time.deltaTime;
        if (EffortTime >= TimeBetweenEfforts)
        {

            Efforts = Mathf.RoundToInt(Efforts + EffortMultiplier * 1.1f);
            EffortTime = 0;
        }
        if (fundingTime >= TimebetweenFunding)
        {
            GovermentFunding = Mathf.RoundToInt(GovermentFunding + FundingMultiplier + Efforts);
            fundingTime = 0;
        }
        EffortText.text = Efforts.ToString() + "K";
        GovernmentFundingText.text = GovermentFunding.ToString();
    }
}
