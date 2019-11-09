using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardGrid : MonoBehaviour
{

    /*   Array consists of integer values.
     *   0 = empty
     *   1 = Tower Level 1
     *   2 = Tower Level 2
     *   3 = Tower Level 3
     *   4 = Player Character 
     */
    static int[,] grid;

    // On start, all the gridTiles are empty.
    private void Start() {
        // makes grid as large as the plane
        grid = new int[20, 20];

        // z - coordinate
        for (int z = 0; z < grid.GetLength(1); z++) {

            // x - coordinate
            for (int x = 0; x < grid.GetLength(0); x++) {

                SetGridTileValue(x, z, 0);
            }
        }
    }

    // returns the whole grid array
    public static int[,] GetGrid() {

        return grid;
    }

    // sets value on position x, z to value.
    public static void SetGridTileValue(int x, int z, int value) {
        Debug.Log(x);
        grid[x, z] = value;
    }

    // returns the value on position x, z.
    public static int GetGridTileValue(int x, int z) {

        return grid[x, z];
    }

}
