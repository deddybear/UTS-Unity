using UnityEngine;
using UnityEngine.UI;

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
        GameManager.instance.GameOver("KAMU MENANG", "Kamu Mendapat Emas Gelap");
    }
}
