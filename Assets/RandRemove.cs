using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandRemove : MonoBehaviour {
    public GameObject One;
    public GameObject Two;
    public GameObject Three;
    private int Seed;
    private int RandInt;
    private MeshCollider coll;
    // Start is called before the first frame update
    void Start() {
        Seed = One.ToString()[0];
        Random.seed = Seed;
        RandInt = Random.Range(0,3);
        switch(RandInt) {
            case 1:
                Two.GetComponent<BoxCollider>().enabled = false;
                Three.GetComponent<BoxCollider>().enabled = false;
                break;
            case 2:
                One.GetComponent<BoxCollider>().enabled = false;
                Three.GetComponent<BoxCollider>().enabled = false;
                break;
            case 3:
                Two.GetComponent<BoxCollider>().enabled = false;
                One.GetComponent<BoxCollider>().enabled = false;
                break;
        }
    }
}
