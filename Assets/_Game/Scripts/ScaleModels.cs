using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleModels : MonoBehaviour
{
    [System.Serializable]
    public struct ModelData
    {
        public Transform model;
        public float scaleMultiplier;
    }

    [SerializeField] private List<ModelData> models;

    private bool isScaledUp = false;

    public void ToggleScale()
    {
        if (isScaledUp)
        {
            foreach (ModelData modelData in models)
            {
                modelData.model.localScale /= modelData.scaleMultiplier;
            }
            isScaledUp = false;
        }
        else
        {
            foreach (ModelData modelData in models)
            {
                modelData.model.localScale *= modelData.scaleMultiplier;
            }
            isScaledUp = true;
        }
    }
}
