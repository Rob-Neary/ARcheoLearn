using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    public GameObject menuObject;
    private bool menuOpen = false;

    public void ToggleMenu()
    {
        menuOpen = !menuOpen;
        menuObject.SetActive(menuOpen);
        Debug.Log("Menu toggled!");
    }
}
