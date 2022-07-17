using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{
    public float berat, tinggiLoncat;
    public GameObject plane, ready, skor, gedungCopy, orangCopy;
    // Start is called before the first frame update
    void Start()
    {

    }

    void OnMouseDown() {
        if (Time.timeScale == 1)
        {
            GameObject.Find("sfx_swooshing").GetComponent<AudioSource>().Play();
            ready.SetActive(false);
            skor.SetActive(true);
            gedungCopy.SetActive(true);
            orangCopy.SetActive(true);
            plane.GetComponent<Rigidbody2D>().gravityScale = berat;
            plane.GetComponent<Rigidbody2D>().velocity = new Vector2(plane.GetComponent<Rigidbody2D>().velocity.x, tinggiLoncat);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
