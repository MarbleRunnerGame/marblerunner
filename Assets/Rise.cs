using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rise : MonoBehaviour {
    public float Speed;
    public float EndingZ;
    private Vector3 spos;
    private Transform t;
    private bool IsRising;
    private float Z;
    private float S;
    private void Start() {
        t = gameObject.GetComponent<Transform>();
        spos = t.position;
        IsRising = false;
        Z = spos.y - EndingZ;
        S = Speed;
        S = Speed;
    }
    // Update is called once per frame
    void Update() {
        if (!IsRising) {
            t.position = new Vector3(t.position.x,t.position.y - S, t.position.z);
        } else {
            t.position = new Vector3(t.position.x, t.position.y + S, t.position.z);
        }
        if (t.position.y <= Z) {
            IsRising = true;
        } else if(t.position.y >= spos.y) {
            IsRising = false;
        }
    }
}
