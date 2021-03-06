﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathNode {
    private Grid<PathNode> grid;
    public int x;
    public int y;

    public bool isWalkable;

    public PathNode(Grid<PathNode> grid, int x, int y) {
        this.grid = grid;
        this.x = x;
        this.y = y;

        isWalkable = true;
    }

    public bool IsWalkable() {
        return isWalkable;
    }
    public void SetIsWalkable(bool isWalkable) {
        this.isWalkable = isWalkable;
    }
}
