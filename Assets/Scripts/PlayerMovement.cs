using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float movementSpeed;


    
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-0.05f * movementSpeed, 0, 0);

        }
        else if (Input.GetKey(KeyCode.D)) 
        {
            transform.Translate(0.05f * movementSpeed, 0, 0);
        }
    }
}
