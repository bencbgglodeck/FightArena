using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementP1 : MonoBehaviour
{

    public float moveSpeed = 5f;


    private Rigidbody rb;

	// Use this for initialization
	void Start ()
    {

        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        Move();
	}


    private void Move()
    {

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical).normalized;
        rb.velocity = movement * moveSpeed;
    }

}
