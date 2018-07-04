using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainbowcubeController : MonoBehaviour {
    public GameObject[] fire;
    int HP;
    int i = 0;
    // Use this for initialization
    void Start () {

        HP = 3;


       
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.tag == "YellowNormalBullet" || col.collider.tag == "GreenNormalBullet" || col.collider.tag == "BlueNormalBullet")
        {
            //特效
            Destroy(col.gameObject);
            HP -= 1;
            
            fire[i].SetActive(false);
            i += 1;
            if (HP==0)
            {
                Destroy(this.gameObject);
            }
          
            
        }
        else if (col.collider.tag=="BombBullet")
        {
            Destroy(col.gameObject);
        }


    }
}
