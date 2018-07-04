using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCreaterController : MonoBehaviour {
    public GameObject[] cubePerfab;
    public float ratetime;
    float nextFire = 3f;
    // Use this for initialization

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        if (Time.time>nextFire)
        {
            nextFire = Time.time + ratetime;

            GameObject sub = Instantiate(cubePerfab[Random.Range(0,3)], transform.position, Quaternion.identity);
        }

    }


    
}
