﻿using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    // Start is called before the first frame update
    public Rigidbody rb;

    public float forwardForce  = 2000f;
    public float sidewaysForce = 500f;

    void Start() {
        Debug.Log("Hello World");

    }

    // Update is called once per frame
    void FixedUpdate() {
        // Add forward forse 
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d")) {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a")) {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
