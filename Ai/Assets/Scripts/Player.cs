using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            rb.AddForce(Vector3.forward * 2);
        if (Input.GetKey(KeyCode.DownArrow))
            rb.AddForce(Vector3.back * 2);
        if (Input.GetKey(KeyCode.LeftArrow))
            rb.AddForce(Vector3.left * 2);
        if (Input.GetKey(KeyCode.RightArrow))
            rb.AddForce(Vector3.right * 2);
    }
}
