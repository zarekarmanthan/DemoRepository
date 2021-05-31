using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveYDirection : MonoBehaviour
{
    public float movSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0,movSpeed*Time.deltaTime,0);
        }  
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0,-movSpeed*Time.deltaTime,0);
        }   
    }
}
