using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PixelColor : MonoBehaviour
{
    public Color NewColor;
    public float ColorSeeAbleness;
    public float UpdateSpeed = 1f;

    float time = 0f;
    SpriteRenderer sr;
    void Start()
    {
        sr = gameObject.GetComponent<SpriteRenderer>();

        if (Random.Range(0, 4) == 1)
        {
            ColorSeeAbleness = Random.Range(0.5f, 1);
            NewColor = new Color(ColorSeeAbleness, 0, 0, 1);
            sr.color = NewColor;
            time = 0;
        }

        if (Random.Range(0, 4) == 2)
        {
            ColorSeeAbleness = Random.Range(0.5f, 1);
            NewColor = new Color(0, 0, ColorSeeAbleness, 1);
            sr.color = NewColor;
            time = 0;
        }

        if (Random.Range(0, 4) == 3)
        {
            ColorSeeAbleness = Random.Range(0.5f, 1);
            NewColor = new Color(0, ColorSeeAbleness, 0, 1);
            sr.color = NewColor;
            time = 0;
        }
    }
    void Update()
    {
        time += Time.deltaTime;
        if (time >= UpdateSpeed)
        {
            if (Random.Range(0, 4) == 1)
            {
                ColorSeeAbleness = Random.Range(0.5f, 1);
                NewColor = new Color(ColorSeeAbleness, 0, 0, 1);
                sr.color = NewColor;
                time = 0;
            }

            if (Random.Range(0, 4) == 2)
            {
                ColorSeeAbleness = Random.Range(0.5f, 1);
                NewColor = new Color(0, 0, ColorSeeAbleness, 1);
                sr.color = NewColor;
                time = 0;
            }

            if (Random.Range(0, 4) == 3)
            {
                ColorSeeAbleness = Random.Range(0.5f, 1);
                NewColor = new Color(0, ColorSeeAbleness, 0, 1);
                sr.color = NewColor;
                time = 0;
            }
        }
    }
}
