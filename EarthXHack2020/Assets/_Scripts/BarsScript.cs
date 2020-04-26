using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarsScript : MonoBehaviour
{
    public PollutionManager PollutionManager;
    public Slider Bar1;
    
    
    void Update()
    {
        Bar1.value =  Mathf.Round(PollutionManager.PollutionAmount/100);
    }
}
