using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayAudio : MonoBehaviour
{
    public AudioSource audioSource;
    public Toggle toggle;
    public bool isMuted = false;

    void Start()
    {
        toggle = transform.Find("ToggleMute").GetComponent<Toggle>();
        audioSource = GetComponent<AudioSource>();
    }

    public void OnClick()
    {
        if (audioSource != null && !isMuted)
        {
            audioSource.Play();
        }
    }

    public void OnToggle()
    {
        isMuted = toggle.isOn;
        audioSource.mute = isMuted;
    }
}


