using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {
    private bool grnded;
    private Rigidbody rb;
    public float Force;
    public bool CanFly;
    private float distToGrnd;
    private Collider col;
    void Start() {
        rb = GetComponent<Rigidbody>();
        col = GetComponent<Collider>();
        distToGrnd = Convert.ToSingle(col.bounds.extents.y);
    }
    private void OnCollisionEnter(Collision collision) {
        if (!CanFly) {
            grnded = Physics.Raycast(transform.position, -Vector3.up, distToGrnd + 10);
        } else {
            grnded = true;
        }
    }
    private void OnCollisionExit(Collision collision) {
        grnded = CanFly;
    }
    private void Update() {
        if(Input.GetButton("Jump") && grnded) {
            rb.AddForce(new Vector3(0,Force,0));
        }
    }
}