using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementP1 : MonoBehaviour
{

    public float moveSpeed = 1f;


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

        if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            rb.velocity += transform.right * Input.GetAxisRaw("Horizontal") * moveSpeed;
        }
        if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
        {
            rb.velocity += transform.forward * Input.GetAxisRaw("Vertical") * moveSpeed;
        }
    }



}
