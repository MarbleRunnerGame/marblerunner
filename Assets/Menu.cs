using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
    private GameObject LS;
    private void Start() {
        LS = GameObject.Find("Canvas/select");
        LS.SetActive(false);
    }
    public void Tutorial() {
        Debug.Log("Changing scene...");
        SceneManager.LoadSceneAsync("Tutorial");
    }
    public void Quit() {
        Application.Quit();
    }
    public void Level(int i) {
        SceneManager.LoadSceneAsync("Level" + i);
    }
    public void ToggleSelect() {
        if(LS.activeSelf) {
            LS.SetActive(false);
        } else {
            LS.SetActive(true);
        }
    }
}
