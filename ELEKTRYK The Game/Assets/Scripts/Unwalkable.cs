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
        SnapToGrid(transform.position);
        SetUnwalkable();
        for (int i = position.x; i < position.x + width; i++)
        {
            for (int j = position.y; j < position.y + height; j++)
            {
                Debug.Log(grid.GetGrid().GetGridObject(i, j).IsWalkable());
            }
        }
    }
    public void SnapToGrid(Vector2 position)
    {
        
        this.position.x = Convert.ToInt32(position.x);
        this.position.y = Convert.ToInt32(position.y);
        
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
