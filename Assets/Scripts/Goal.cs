using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class Goal : MonoBehaviour
{
    private AudioSource audioSrc;

    void Awake()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {

        Destroy(other.gameObject);
        GameManager.instance.RestartGame(2.5f);
    }
}
