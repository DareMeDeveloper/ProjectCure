using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Affected : MonoBehaviour
{
    public GameObject[] ParticalSqaures;
    PollutionManager pollution;
    float oldPollutionAmount = 0;
    float DotAmountController = 0;
    int RandomSelected;
    void Start()
    {
        pollution = GetComponent<PollutionManager>();
        oldPollutionAmount = pollution.PollutionAmount;
    }
    void Awake()
    {
        for (int i = 0; i <= 100; i++)
        {
            RandomSelected = Random.Range(0, ParticalSqaures.Length);
            ParticalSqaures[RandomSelected].GetComponent<SpriteRenderer>().color = Color.red;
        }
    }
    float timeforNextDot;
    float timebtwNextDot = 0.25f;
    float time;
    float timebtw = 6;
    void Update()
    {
        timebtw = pollution.PollutionAmountBtw;
        time += Time.deltaTime;
        if (time >= timebtw)
        {
            oldPollutionAmount = pollution.PollutionAmount;
            time = 0f;
        }
        if (DotAmountController <= pollution.PollutionAmount)
        {
            timeforNextDot += Time.deltaTime;
            if (timeforNextDot >= timebtwNextDot)
            {
                RandomSelected = Random.Range(0, ParticalSqaures.Length - 1);
                ParticalSqaures[RandomSelected].GetComponent<SpriteRenderer>().color = Color.red;
                DotAmountController++;
                timeforNextDot = 0;
            }
        }
        if (oldPollutionAmount >= pollution.PollutionAmount)
        {
            timeforNextDot += Time.deltaTime;
            if (timeforNextDot >= timebtwNextDot)
            {
                timeforNextDot = 0f;
                if (ParticalSqaures[RandomSelected].GetComponent<SpriteRenderer>().color == Color.red)
                {
                    ParticalSqaures[RandomSelected].GetComponent<SpriteRenderer>().color = Color.clear;
                }
                else
                {
                    RandomSelected = Random.Range(0, ParticalSqaures.Length - 1);
                    if (ParticalSqaures[RandomSelected].GetComponent<SpriteRenderer>().color == Color.red)
                    {
                        ParticalSqaures[RandomSelected].GetComponent<SpriteRenderer>().color = Color.clear;
                    }
                }
            }
        }

    }

}

