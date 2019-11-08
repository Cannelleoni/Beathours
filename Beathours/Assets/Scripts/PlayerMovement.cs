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
    }


    //classObject[] coArr = new classObject[400];





}
