using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour {
    public Vector3 Pos;
    private void OnCollisionEnter(Collision col) {
        if (col.collider.tag=="Death") Die();
    }
    private void Die() => transform.position = Pos;
}
