/*
    Do przerobienia na pathfinding
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateGrid : MonoBehaviour {

    [SerializeField] int width = 100;
    [SerializeField] int height = 100;
    [SerializeField] float cellSize = 1f;

    private Grid<PathNode> grid;

    private void Awake() {
        grid = new Grid<PathNode>(width, height, cellSize, new Vector3(0, 0), (Grid<PathNode> g, int x, int y) => new PathNode(g, x, y));
    }
    public Grid<PathNode> GetGrid() {
        return grid;
    }
}