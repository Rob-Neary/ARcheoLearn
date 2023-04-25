using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchRotate : MonoBehaviour
{
    public float sensitivity = 1f;

    private float _rotationX;
    private float _rotationY;

    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
            _rotationX += touchDeltaPosition.x * sensitivity;
            _rotationY += touchDeltaPosition.y * sensitivity;
            transform.rotation = Quaternion.Euler(_rotationY, _rotationX, 0f);
        }
    }
}

