using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;

    void Awake()
    {
        instance = this;
    }

    public void RestartGame(float delay)
    {
        PlayerController.speedMultiplier = 0f;
        StartCoroutine(RestartGameCoroutine(delay));
    }

    private IEnumerator RestartGameCoroutine(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene("SampleScene");
        PlayerController.speedMultiplier = 3.5f;
    }

}
