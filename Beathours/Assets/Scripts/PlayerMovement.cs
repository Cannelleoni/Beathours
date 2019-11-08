using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] float speed;

    [SerializeField] GameObject tower, newParent;


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

    public void changeParent()
    {
        tower.transform.SetParent(newParent.transform);
        tower.transform.position = new Vector3(transform.position.x, transform.position.y + 1.25f, transform.position.z);
    }

    //classObject[] coArr = new classObject[400];





}
