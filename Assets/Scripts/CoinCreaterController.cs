using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCreaterController : MonoBehaviour {
    public GameObject[] coinPerfab;
    public float coinRate;
    // Use this for initialization
    float nextFire = 0;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Time.time > nextFire)
        {
            nextFire = Time.time + coinRate;


            Instantiate(coinPerfab[Random.Range(0, 6)], transform.position, Quaternion.identity);



        }


    }
}
