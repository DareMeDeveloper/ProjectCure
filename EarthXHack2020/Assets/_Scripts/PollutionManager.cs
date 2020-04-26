using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PollutionManager : MonoBehaviour
{
    public float PollutionAmountBtw = 3f;
    public float PollutionAmount;
    public float PollutionRate = 308f;
    float Ptime = 0f;

    GameManager GM;
    // Start is called before the first frame update
    void Start()
    {
        GM = GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        Ptime += Time.deltaTime;
        if (Ptime >= PollutionAmountBtw)
        {
            PollutionAmount += 308;
            PollutionAmount -= GM.Efforts;
            Ptime = 0f;
        }
    }
}
