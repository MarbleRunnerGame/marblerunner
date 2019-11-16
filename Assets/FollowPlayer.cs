using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        
    }

    public GameObject Player;
    public float XOffset;
    public float ZOffset;

    // Update is called once per frame
    void Update() {
        transform.position = new Vector3(Player.transform.position.x+XOffset,transform.position.y,Player.transform.position.z+ZOffset);
    }
}

