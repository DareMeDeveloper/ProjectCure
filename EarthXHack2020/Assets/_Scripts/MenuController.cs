using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    public GameObject EarthImage;
    public GameObject MainMenu;
    public GameObject Mutations;
    public GameObject Efforts;

    public void OpenUpgrades()
    {
        EarthImage.SetActive(false);
        MainMenu.SetActive(false);
        Mutations.SetActive(true);
    }
    public void CloseUpgrades()
    {
        EarthImage.SetActive(true);
        MainMenu.SetActive(true);
        Mutations.SetActive(false);
    }
    public void OpenEfforts()
    {
        EarthImage.SetActive(false);
        MainMenu.SetActive(false);
        Efforts.SetActive(true);
    }
    public void CloseEfforts()
    {
        EarthImage.SetActive(true);
        MainMenu.SetActive(true);
        Efforts.SetActive(false);
    }

}
