using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
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
            int2 mousePos = Utils.SnapToGrid(mainCamera.ScreenToWorldPoint(Input.mousePosition));
            Debug.Log("X: " + mousePos.x + "Y: " + mousePos.y);
        }
    }
}
