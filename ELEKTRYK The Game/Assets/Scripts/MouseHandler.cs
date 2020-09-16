using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHandler : MonoBehaviour
{
    Camera mainCamera;
    private void Start()
    {
        mainCamera = Camera.main;
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
            Debug.Log("X: " + Convert.ToInt32(mousePos.x) + "Y: " + Convert.ToInt32(mousePos.y));
        }
    }
}
