using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Utils {

    public static int2 SnapToGrid(Vector2 position)
    {
        int2 snappedPos;
        snappedPos.x = Convert.ToInt32(position.x);
        snappedPos.y = Convert.ToInt32(position.y);
        return snappedPos;
    }
}