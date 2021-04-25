using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    
    public GameObject MenuUI;
    public Text textMenu;
    public Text textStatus;
    public static GameManager instance;
    public bool statusPause = false;
    public static bool isKeyEnabled = true;

    void Awake()
    {
        // MenuUI = GameObject.Find("Menu");
        instance = this;
    }

    void Update() {

        if (isKeyEnabled) {
             if (Input.GetKeyDown(KeyCode.Escape)) {
                
                if (statusPause) {
                    Resume();
                } else {
                    Pause();
                }
          
            }
        }
        
    }

    void Resume() {
        textMenu.text = "";
        MenuUI.SetActive(false);
        Time.timeScale = 1f;
        statusPause = false;
    }

    void Pause() {
        textMenu.text = "Game Paused";
        MenuUI.SetActive(true);
        Time.timeScale = 0f;
        statusPause = true;
    }

    public void GameOver(string judul, string statusPlayer) {
        isKeyEnabled    = false;
        textMenu.text   = judul;
        textStatus.text = statusPlayer;
        MenuUI.SetActive(true);
    }

    public void RestartGame(float delay) {
        PlayerController.speedMultiplier = 0f;
        StartCoroutine(RestartGameCoroutine(delay));
    }

    private IEnumerator RestartGameCoroutine(float delay) {
        isKeyEnabled = true;
        MenuUI.SetActive(false);
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene("SampleScene");
        PlayerController.speedMultiplier = 3.5f;
    }

}
