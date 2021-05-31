using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movSpeed = 50f; 
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-movSpeed*Time.deltaTime,0, 0);
        }
       else if( Input.GetKey(KeyCode.D))
        {
            transform.Translate(movSpeed * Time.deltaTime, 0, 0);
        }
    }
}
