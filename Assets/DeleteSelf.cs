using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Default {
#pragma warning disable IDE1006 // Naming Styles
    public string name { get; }
#pragma warning restore IDE1006 // Naming Styles
    public Default() {
        name = "player";
    }
}

public class DeleteSelf : MonoBehaviour {
    public GameObject Player;
    private void OnCollisionEnter(Collision col) {
        if (Player == null) {
            if (col.collider.name == "Player") {
                gameObject.SetActive(false);
            }
        } else {
            if (col.collider.name == Player.name) {
                gameObject.SetActive(false);
            }
        }
    }
}
