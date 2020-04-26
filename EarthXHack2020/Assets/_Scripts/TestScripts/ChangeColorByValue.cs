using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ChangeColorByValue : MonoBehaviour
{
    public Color NewRed;
    public Color normalColor;
    public float Redness;
    public float transitionSpeed = 25;
    SpriteRenderer sr;
    void Start()
    {
        
        sr = gameObject.GetComponent<SpriteRenderer>();
        /*
        sr.color = Color.white;
        Redness = Random.Range(200, 700);
        */
    }
    public void AddRed()
    {
        if (Redness < 700)
        {
            Redness += transitionSpeed;
        }
    }
    public void RemoveRed()
    {
        if (Redness > 200)
        {
            Redness -= transitionSpeed;
        }
    }
    void Update()
    {
        /*
        Debug.Log(NewRed);
        NewRed = new Color(Redness + 200, 200f / Redness, 200f / Redness);
        sr.color = NewRed;
        */
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigger Activated");
        Redness = Random.Range(200, 700);
        NewRed = new Color(Redness + 200, 200f / Redness, 200f / Redness);
        sr.color = NewRed;
    }
}
