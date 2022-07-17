using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gedung : MonoBehaviour
{
    float Ygedung;
    public float kecepatan;

    // Start is called before the first frame update
    void Start()
    {
        Ygedung = Random.Range(0, -4);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 1)
        {
            transform.localPosition = new Vector3(transform.localPosition.x - kecepatan, Ygedung, 1f);
        }
    }
}
