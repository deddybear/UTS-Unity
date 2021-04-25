using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TembokKematian : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.transform.tag == "Player")
        {
            GameManager.instance.GameOver("YOU LOSE !", "Kamu Menabrak diding kematian");
        }
        else
        {
            if (transform.parent != null)
            {
                GameManager.instance.GameOver("YOU LOSE !", "Kamu Menabrak diding kematian");
            }
            else
            {
               GameManager.instance.GameOver("YOU LOSE !", "Kamu Menabrak diding kematian");
            }
        }
    }
}
