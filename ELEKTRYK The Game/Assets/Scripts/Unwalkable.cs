using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Unwalkable : MonoBehaviour
{
    [SerializeField] int height = 1;
    [SerializeField] int width = 1;

    CreateGrid grid;
    int2 position;
    void Start()
    {
        grid = FindObjectOfType<CreateGrid>();
        position = Utils.SnapToGrid(transform.position);
        SetUnwalkable();
        for (int i = position.x; i < position.x + width; i++)
        {
            for (int j = position.y; j < position.y + height; j++)
            {
                Debug.Log(grid.GetGrid().GetGridObject(i, j).IsWalkable());
            }
        }
    }
    
    private void SetUnwalkable() { 
        for(int i = position.x; i < position.x + width; i++)
        {
            for(int j = position.y; j < position.y + height; j++)
            {
                grid.GetGrid().GetGridObject(i, j).SetIsWalkable(false);
            }
        }
    }
    

}
