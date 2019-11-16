using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour {
    public GameObject Player;
    void OnCollisionEnter(Collision col) {
        if(Player.name == col.collider.name) {
            SceneManager.LoadSceneAsync("Menu");
        }
    }
}
