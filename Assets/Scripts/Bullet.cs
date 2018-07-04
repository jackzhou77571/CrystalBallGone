using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    public float BulletSpeed;
    Rigidbody2D Brd;

	// Use this for initialization
	void Start () {
        Brd = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        Brd.velocity = new Vector2(0, BulletSpeed);
	}
}
