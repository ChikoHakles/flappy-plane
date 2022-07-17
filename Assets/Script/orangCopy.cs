using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orangCopy : MonoBehaviour
{
    public GameObject orang;

    // Start is called before the first frame update
    void Start()
    {

    }

    void copy()
    {
        Instantiate(orang, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

