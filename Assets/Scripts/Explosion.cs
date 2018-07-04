using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {
    Rigidbody2D rb;
	// Use this for initialization
	void Start () {
        Destroy(gameObject, 0.30f);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "ColorBrick")
        {
            rb =other. GetComponent<Rigidbody2D>();
           
            Destroy(other.gameObject);

            if (Time.timeScale == 1.0f)
            {
                Time.timeScale = 0.8f;
            }
           
        }
    }
}
