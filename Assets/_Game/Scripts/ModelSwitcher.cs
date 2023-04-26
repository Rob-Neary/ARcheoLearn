using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelSwitcher : MonoBehaviour
{
    public GameObject imageTarget;
    private int currentModelIndex = 0;

    private void Start()
    {
        // Activate the first 3D model and deactivate the others
        for (int i = 0; i < imageTarget.transform.childCount; i++)
        {
            var child = imageTarget.transform.GetChild(i).gameObject;
            if (child.tag == "3DModel")
            {
                child.SetActive(i == currentModelIndex);
            }
        }
    }

    public void OnButtonPressed()
    {
        // Deactivate the current 3D model
        imageTarget.transform.GetChild(currentModelIndex).gameObject.SetActive(false);

        // Increment the current model index
        currentModelIndex++;
        if (currentModelIndex >= imageTarget.transform.childCount)
        {
            currentModelIndex = 0;
        }

        // Activate the new 3D model
        imageTarget.transform.GetChild(currentModelIndex).gameObject.SetActive(true);
    }
}


