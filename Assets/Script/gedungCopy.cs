using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gedungCopy : MonoBehaviour
{
    public GameObject gedung;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void copy()
    {
        Instantiate(gedung, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
