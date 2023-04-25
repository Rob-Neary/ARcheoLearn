using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSound : MonoBehaviour
{
  
    private Sprite soundOnImage;
    public Sprite soundOffImage;
    private Image image;
    private bool isOn = true;
    
    public AudioSource audioSource;
    
    void Start()
    {
        image = GetComponent<Image>();
        soundOnImage = image.sprite; 
    }

    public void ButtonClicked()
    { 
    if (isOn)
        {
            image.sprite = soundOffImage;
            isOn = false;
           audioSource.mute = true;
        }
    else
        {
            image.sprite = soundOnImage;
            isOn = true;
           audioSource.mute = false;
        }
    }

}
