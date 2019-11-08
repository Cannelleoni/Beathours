using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] float speed;

    [SerializeField] GameObject tower, newParent;

    Vector3 standstill = new Vector3(0 , 0, 0);

    private void Start()
    {
        
    }

    private void Update()
    {//
        // rechts
        if(InputManager.mainJoyStick() != standstill)
        {
            rb.MovePosition(transform.position + InputManager.mainJoyStick() * Time.deltaTime * speed);
            
            
                float yAngl = Mathf.Atan2(InputManager.mainHorizontal(), InputManager.mainVertical()); // NEW AND HAS TO STAY
                yAngl = Mathf.Rad2Deg * yAngl;                                                                                      // rb.transform.Rotate(0,yAngl,0,Space.World); // NEW AND HAS TO STAY
                print(yAngl);
                rb.transform.rotation = Quaternion.Euler(0, -yAngl, 0);



            //rb.transform.rotation = Quaternion.Euler(0, yAngl, 0);
        } 

        if(transform.position.y < -2f)
        {
            transform.position = new Vector3(-3.5f, .25f, -2.5f);
        }
        

        
    }

    public void changeParent()
    {
        tower.transform.SetParent(newParent.transform);
        tower.transform.position = new Vector3(transform.position.x, transform.position.y + 1.8f, transform.position.z);
    }

    //classObject[] coArr = new classObject[400];





}
