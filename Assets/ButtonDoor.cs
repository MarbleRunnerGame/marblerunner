using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDoor : MonoBehaviour {
    // Start is called before the first frame update
    public GameObject Remove;
    public bool AddRemove;
    public GameObject Spawn;
    public bool RemoveSpawn;
    public GameObject Player;
    public Material OnMaterial;
    public Material OffMaterial;
    void Start() {
        if (Remove != null && AddRemove) Remove.SetActive(true);
        if (Spawn != null && RemoveSpawn) Spawn.SetActive(false);
        gameObject.GetComponent<Renderer>().material = OffMaterial;
    }
    private void OnCollisionEnter(Collision col) {
        if (col.collider.name == Player.name) {
            if (Remove != null) Remove.SetActive(false);
            if (Spawn != null) Spawn.SetActive(true);
            gameObject.GetComponent<Renderer>().material = OnMaterial;
        }
    }
}
