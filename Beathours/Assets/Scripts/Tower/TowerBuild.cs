using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerBuild : MonoBehaviour
{
    [SerializeField] GameObject player;
    Vector3 playerPosition;
    [SerializeField] GameObject gridTile, gridTileRed;
    float lastHorizontal, lastVertical;
    GameObject currentFocusedTile;
    Material material;

    // Start is called before the first frame update
    void Start()
    {
        lastHorizontal = 0;
        lastVertical = 0;
        currentFocusedTile = Instantiate(gridTile, new Vector3((int)player.transform.position.x, 0, (int)player.transform.position.z), Quaternion.identity);
        material = gridTile.GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        markTileAsBuildable();
    }

    public void markTileAsBuildable() {

        lastHorizontal = InputManager.mainHorizontal();
        lastVertical = InputManager.mainVertical();
        playerPosition = new Vector3(player.transform.position.x, 0, player.transform.position.z);

            // above
            if (lastVertical < 0) {

                currentFocusedTile.transform.position = new Vector3((int)Mathf.Round(playerPosition.x), 0, Mathf.Ceil(playerPosition.z + 1));

                // green
                if (BoardGrid.GetGridTileValue((int)Mathf.Round(playerPosition.x), (int)Mathf.Ceil(playerPosition.z)) == 0) {

                material.color = Color.green;
                }

                // red
                else {

                }
            }
            // below
            else if (lastVertical > 0) {

                currentFocusedTile.transform.position = new Vector3((int)Mathf.Round(playerPosition.x), 0, Mathf.Floor(playerPosition.z - 1));

                //green
                if (BoardGrid.GetGridTileValue((int)Mathf.Round(playerPosition.x), (int)Mathf.Floor(playerPosition.z - 1)) == 0) {


                }

                // red
                else {

                }
            }

            // right
            if (lastHorizontal > 0) {

                currentFocusedTile.transform.position = new Vector3(Mathf.Ceil(playerPosition.x + 1), 0, (int)Mathf.Round(playerPosition.z));

                // green
                if (BoardGrid.GetGridTileValue((int)Mathf.Ceil(playerPosition.x), (int)Mathf.Round(playerPosition.z)) == 0) {


                }

                // red
                else {

                }
            }

            // left
            else if (lastHorizontal < 0) {

                currentFocusedTile.transform.position = new Vector3(Mathf.Floor(playerPosition.x - 1), 0, (int)Mathf.Round(playerPosition.z));

                // green
                if (BoardGrid.GetGridTileValue((int)Mathf.Floor(playerPosition.x - 1), (int)Mathf.Round(playerPosition.z)) == 0) {

                }

                // red
                else {

                }
            }
    }
}
