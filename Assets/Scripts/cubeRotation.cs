using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeRotation : MonoBehaviour {
    
    public float CubeRotateSpeed;
    
	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(CubeRotateSpeed*Time.deltaTime, 0f,0f);
        
	}
}
