using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballCreaterController : MonoBehaviour {
    public GameObject[] ballPerfab;
    public float fireRate;
    // Use this for initialization
    float nextFire = 0;
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {


        if (Time.time>nextFire)
        {
            
            nextFire = Time.time + fireRate;
            TimeSpeedGoBack();
            
            Instantiate(ballPerfab[Random.Range(0,10)], transform.position, Quaternion.identity);

            

        }

        



    }

    void TimeSpeedGoBack()
    {
        if (Time.timeScale <1f)
        {
            Time.timeScale = 1f;
        }
    }
}
