using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Movement Script for the 3D Asteroid game





public class Movement : MonoBehaviour {

    public float maxSpeed;
    public float currentSpeed;


    public float acelRate;
    public float decelRate;

    public float rotaSpeed;

    Rigidbody rb;
    

    



    // Use this for initialization
    void Start () {

        Physics.gravity = new Vector3(0, 0, 0);

        rb = GetComponent<Rigidbody>();
        currentSpeed = rb.velocity.magnitude;
        
	}
	
	// Update is called once per frame
	void Update () {

        

        if (Input.GetKey(KeyCode.W))
        {
            if( currentSpeed <= maxSpeed )
            {
                rb.AddRelativeForce(Vector3.forward * Time.deltaTime* acelRate);
                currentSpeed += acelRate;
            }

            if(currentSpeed > maxSpeed) { currentSpeed = maxSpeed; }
        }

        if (Input.GetKey(KeyCode.S))
        {
            if (currentSpeed <= maxSpeed )
            {
                rb.AddRelativeForce(Vector3.back * Time.deltaTime * decelRate);
                currentSpeed -= decelRate;
            }
            if (currentSpeed < -maxSpeed) { currentSpeed = -maxSpeed; }
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, 0, rotaSpeed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0, -rotaSpeed);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, rotaSpeed, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, -rotaSpeed, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(rotaSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(-rotaSpeed, 0, 0);
        }



    }
}


