using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] float speed;
    float x, z;

    private void Start() {

        updateGridArray(new Vector3(rb.transform.position.x, 0, rb.transform.position.z), 4);
    }

    private void Update()
    {

        x = Mathf.Floor(rb.transform.position.x);
        z = Mathf.Floor(rb.transform.position.z);

        removePlayerFromTile();

        // Player movement
        if (InputManager.mainJoyStick() != null)
        {
            rb.MovePosition(transform.position + InputManager.mainJoyStick() * Time.deltaTime * speed);
            
            // set state of current gridTile to 4 (player on the tile)
            updateGridArray(new Vector3(Mathf.Floor(x), 0, Mathf.Floor(z)), 4);
        } 
    }

    // sets back the value of the tiles around the player to 0
    public void removePlayerFromTile() {

        // checking which tile has to be updated
        if (InputManager.mainHorizontal() == 0) {

            // above
            if (InputManager.mainVertical() > 0) {

                updateGridArray(new Vector3(x, 0, z + 1), 0);
            }
            // below
            else if (InputManager.mainVertical() < 0) {

                updateGridArray(new Vector3(x, 0, z - 1), 0);
            }
        }
        else if (InputManager.mainVertical() == 0) {

            // right
            if (InputManager.mainHorizontal() > 0) {

                updateGridArray(new Vector3(x + 1, 0, z), 0);
            }
            // left
            else if (InputManager.mainHorizontal() < 0) {

                updateGridArray(new Vector3(x - 1, 0, z), 0);
            }
        }
    }
    // method to update GridArray
    public void updateGridArray(Vector3 pos,  int value) {


        BoardGrid.SetGridTileValue((int)pos.x, (int)pos.z, value);

    }

    // returns current position of player
    public Vector3 GetPlayerPosition() {

        return new Vector3(rb.transform.position.x, 0, rb.transform.position.z);
    }
}
