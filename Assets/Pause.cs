using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour {
    public GameObject PauseUi;
    // Start is called before the first frame update
    void Start() {
        if(PauseUi==null) {
            Debug.Log("Please specify a UI for pausing!");
            return;
        }
        PauseUi.SetActive(false);
    }
    // Update is called once per frame
    void Update() {
        if(Input.GetButtonDown("Cancel")) {
            Toggle();
        }
    }
    public void Toggle() {
        if(PauseUi.activeSelf) {
            Time.timeScale = 1f;
            PauseUi.SetActive(false);
        } else {
            Time.timeScale = 0f;
            PauseUi.SetActive(true);
        }
    }
    public void Restart() {
        Time.timeScale = 1f;
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().name);
    }
    public void Menu() {
        Time.timeScale = 1f;
        SceneManager.LoadSceneAsync("Menu");
    }
}
