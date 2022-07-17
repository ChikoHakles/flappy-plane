using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plane : MonoBehaviour
{
    public GameObject skor, control, gameOver;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "hit")
        {
            GameObject.Find("ground-hit").GetComponent<AudioSource>().Play();
            gameOver.SetActive(true);
            control.SetActive(false);
            Time.timeScale = 0;
        }
        else if (other.gameObject.tag == "addscore")
        {
            GameObject.Find("score sound").GetComponent<AudioSource>().Play();
            skor.GetComponent<skor>().score++;
        }
    }
}
