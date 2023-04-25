using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FunFactsAnim : MonoBehaviour
{
    private bool isAnimationStarted = false;
    private LTDescr moveTween;
    private LTDescr scaleTween;

    public Button button;
    public AudioSource audioSource;
    public bool isMuted = false;

    void Update()
    {
        if (!isAnimationStarted)
        {
            StartAnim();
            isAnimationStarted = true;
        }
    }

    public void OnClick()
    {
        if (isAnimationStarted)
        {
            StopAnim();
            // Move the button offscreen to position (700, 0) before playing the audio
            this.button.transform.LeanMoveLocal(new Vector2(1200, 0), 0.7f).setEaseOutQuart().setOnComplete(() => {
                if (audioSource != null && !isMuted)
                {
                    audioSource.Play();
                }
                // Set isAnimationStarted to false after the audio has finished playing
                isAnimationStarted = false;
            });
        }
        else
        {
            if (audioSource != null && !isMuted)
            {
                audioSource.Play();
            }
        }
    }


    public void StartAnim()
    {
        if (isAnimationStarted)
        {
            return;
        }

        moveTween = transform.LeanMoveLocal(new Vector2(250, 0), 0.7f).setEaseOutQuart().setLoopPingPong();
        isAnimationStarted = true;
    }

    public void StopAnim()
    {
        if (moveTween != null)
        {
            LeanTween.cancel(moveTween.id);
            moveTween = null;
        }

        if (scaleTween != null)
        {
            LeanTween.cancel(scaleTween.id);
            scaleTween = null;
        }

        if (button != null)
        {
            // Move the button offscreen
            button.transform.LeanMoveLocal(new Vector2(1200, 0), 0.7f).setEaseOutQuart();
        }
    }
}



