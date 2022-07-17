using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orang : MonoBehaviour
{
    public float kecepatan, Yorang, Xorang;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 1)
        {
            transform.localPosition = new Vector3(transform.localPosition.x - kecepatan, Yorang, 1f);
        }
    }
}
