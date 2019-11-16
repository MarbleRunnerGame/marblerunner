using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#pragma warning disable IDE1006 // Naming Styles
public class move : MonoBehaviour
{
#pragma warning restore IDE1006 // Naming Styles
                               // Start is called before the first frame update
    private Rigidbody rb;

    public int Speed;

    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {
        float h = Input.GetAxis("Horizontal") * Speed;
        float v = Input.GetAxis("Vertical") * Speed;

        h *= Time.deltaTime;
        v *= Time.deltaTime;

        rb.AddForce(new Vector3(h,0,v));
    }
}
