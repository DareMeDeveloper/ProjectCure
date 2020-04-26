using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MiniGame : MonoBehaviour
{
    UpgradeMenuManager upgradeMenu;
    public GameObject MiniObject;
    public TextMeshProUGUI Text1;
    public TextMeshProUGUI Text2;
    public TextMeshProUGUI Text3;
    void Start()
    {
        upgradeMenu = GetComponent<UpgradeMenuManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (upgradeMenu.isBuying == true)
        {
            MiniObject.SetActive(true);
        }
    }
    public void PickedThisCard1()
    {
        if (upgradeMenu.isBuying == true)
        {
            Text1.gameObject.SetActive(true);
            Text1.text = "It was " + Random.Range(0, 100).ToString() + "% effective";
            upgradeMenu.isBuying = false;
        }
    }
    public void PickedThisCard2()
    {
        if (upgradeMenu.isBuying == true)
        {
            Text2.gameObject.SetActive(true);
            Text2.text = "It was " + Random.Range(0, 100).ToString() + "% effective";
            upgradeMenu.isBuying = false;
        }
    }
    public void PickedThisCard3()
    {
        if (upgradeMenu.isBuying == true)
        {
            Text3.gameObject.SetActive(true);
            Text3.text = "It was " + Random.Range(0, 100).ToString() + "% effective";
            upgradeMenu.isBuying = false;
        }
    }
    public void ExitMiniGame()
    {
        MiniObject.SetActive(false);
        Text1.gameObject.SetActive(false);
        Text2.gameObject.SetActive(false);
        Text3.gameObject.SetActive(false);
    }
}
