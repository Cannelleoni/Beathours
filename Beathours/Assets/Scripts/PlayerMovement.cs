using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] float speed;


    private void Update()
    {
        // rechts
        if(InputManager.mainJoyStick() != null)
        {
            rb.MovePosition(transform.position + InputManager.mainJoyStick() * Time.deltaTime * speed);
        } 

        if(transform.position.y < -2f)
        {
            transform.position = new Vector3(-3.5f, .25f, -2.5f);
        }
    }


    //classObject[] coArr = new classObject[400];





}
