using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewDotSystem : MonoBehaviour
{
    public float impactAmount;

    public float time;
    float TimebtwSpread = 3;
    SpriteRenderer sr;
    public Collider2D m_other;
    void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        if (sr.color.a != 0f)
        {
            time += Time.deltaTime;
            if (time >= TimebtwSpread && m_other != null)
            {
                m_other.gameObject.GetComponent<SpriteRenderer>().color = new Color(sr.color.r, sr.color.g, sr.color.b, m_other.GetComponent<SpriteRenderer>().color.a + impactAmount);
                time = 0f;
            }
            else if (time >= TimebtwSpread)
            {
                time = 0f;
            }

        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Dot") && other.GetComponent<NewDotSystem>().m_other != gameObject.GetComponent<BoxCollider2D>())
        {
            m_other = other;
            time = 0f;
        }

    }
}
