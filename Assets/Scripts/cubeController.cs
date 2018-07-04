using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeController : MonoBehaviour {
    
    public float DownSpeed;
    Rigidbody2D CRb;
    // Use this for initialization
   

    void Start () {
        CRb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        CubeDownSpeed();
	}

    public void CubeDownSpeed()
    {
        CRb.velocity = new Vector2(0f, DownSpeed);
    }
   
}
