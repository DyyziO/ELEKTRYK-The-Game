using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateGrid : MonoBehaviour {

    [SerializeField] int width = 100;
    [SerializeField] int height = 100;
    [SerializeField] float cellSize = 1f;

    private Grid grid;

    private void Start() {
        grid = new Grid(width, height, cellSize, new Vector3(0, 0));
    }
}
