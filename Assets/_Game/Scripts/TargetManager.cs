using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TargetManager : MonoBehaviour
{
    [SerializeField]
    private GameObject Pyramid;

    [Serializable]
    public enum Targets
    {
        Pyramid,
        Sphinx
    };

    public void TrackerLost(string TheTarget)
    {
        switch (TheTarget)
        {
            case "Pyramid":
                if (Pyramid != null)
                    Pyramid.SetActive(false);
                break;
        }
    }

    public void TrackerFound(string TheTarget)
    {
        switch (TheTarget)
        {
            case "Pyramid":
                if (Pyramid != null)
                    Pyramid.SetActive(true);
                break;
        }
    }
}
