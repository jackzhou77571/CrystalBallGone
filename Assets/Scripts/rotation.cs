using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour {
    public Transform[] target;

    public float rotationSpeed;
    public float moveSpeed;
    float differentspeed;

    private int current;
    Rigidbody2D Rb;

	// Use this for initialization
	void Start () {
      differentspeed = Random.Range(1.0f, 1.5f);

        Rb = GetComponent<Rigidbody2D>();

    }
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0, 0, rotationSpeed* differentspeed * Time.deltaTime);
        //Rb.velocity = new Vector3(moveSpeed*Time.deltaTime,0);
        if (transform.localScale.x<1.2)
        {
            transform.localScale += new Vector3(0.3f * Time.deltaTime, 0.3f * Time.deltaTime, 0);
        }


        if (transform.position != target[current].position)
        {
            Vector2 pos = Vector2.MoveTowards(transform.position, target[current].position, moveSpeed * Time.deltaTime);
            GetComponent<Rigidbody2D>().MovePosition(pos);
        }
        else current = (current + 1) % target.Length;
	}

    void Bullet()
    {

        Rb.AddForce(new Vector2(-1,50));
    }

    
}
