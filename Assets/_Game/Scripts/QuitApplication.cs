using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class QuitApplication : MonoBehaviour
{
    public GameObject confirmationPanel;

    public void Quit()
    {
        confirmationPanel.SetActive(true);
    }

    public void ConfirmQuit()
    {
        Application.Quit();
    }

    public void CancelQuit()
    {
        confirmationPanel.SetActive(false);
    }
}
