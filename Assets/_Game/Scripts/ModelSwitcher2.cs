using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModelSwitcher2 : MonoBehaviour
{
    // References to the different models
    public GameObject Khafre;
    public GameObject King_Menkaure;
    public GameObject Petra;

    // The current state of the app
    private enum AppState { ImageTarget, Model_1, Model_2 }
    private AppState currentState;

    // Reference to the image target
    private GameObject imageTarget;

    private void Start()
    {
        // Get a reference to the image target
        imageTarget = GameObject.Find("KhafreImageTarget");

        // Initialise the app in the ImageTarget state
        currentState = AppState.ImageTarget;

        // Activate the image target model and deactivate the others
        Khafre.SetActive(true);
        King_Menkaure.SetActive(false);
        Petra.SetActive(false);
    }

    private void Update()
    {
        // Check if the image target is being tracked
        if (imageTarget && imageTarget.activeInHierarchy)
        {
            // If we are in a standalone state, switch back to the ImageTarget state
            if (currentState != AppState.ImageTarget)
            {
                currentState = AppState.ImageTarget;

                Khafre.SetActive(true);
                King_Menkaure.SetActive(false);
                Petra.SetActive(false);
            }
        }
    }

    public void ShowKingMenkaure()
    {
        // Activate the Car model and deactivate the others
        currentState = AppState.Model_1;

        Khafre.SetActive(false);
        King_Menkaure.SetActive(true);
        Petra.SetActive(false);
    }

    public void ShowPetra()
    {
        // Activate the Plane model and deactivate the others
        currentState = AppState.Model_2;

        Khafre.SetActive(false);
        King_Menkaure.SetActive(false);
        Petra.SetActive(true);
    }
}