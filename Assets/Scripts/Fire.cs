using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour {
    public GameObject Firepoint;

    

    public GameObject GreenBulletNormal;
    public GameObject YellowBulletNormal;
    public GameObject BlueBulletNormal;
    //public GameObject RainbowBall;
    public GameObject BombBall;

   
    public bool isButton;
    [HideInInspector]
    public bool BulletShoot;

    private bool isGreenNormal;
    private bool isYellowNormal;
    private bool isBlueNormal;
    // private bool isRainbowBall;
    private bool isBombBall;

    private bool isShootGreenBall;
    private bool isShootYellowBall;
    private bool isShootBlueBall;
    // private bool isShootRainbowBall;
    private bool isShootBombBall;
    
    
    
    
    // Use this for initialization

    public void FireButton()
    {
        isButton = true;
    }
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        //bullet-blue  two kinds
    }

    void OnTriggerStay2D(Collider2D other)
    {
        
        //green
        
        if (other.tag == "GreenNormalBall" && isButton)
        {
            Destroy(other.gameObject);
            isButton = false;
            isShootGreenBall = true;
            if (isShootGreenBall)
            {
                Instantiate(GreenBulletNormal, Firepoint.transform.position, Quaternion.identity);
                
                isShootGreenBall = false;
            }
        }
        else 
        {
            isGreenNormal = false;
        }

        //yellow

       

        if (other.tag == "YellowNormalBall" && isButton)
        {
            Destroy(other.gameObject);
            isButton = false;
            isShootYellowBall = true;
            if (isShootYellowBall)
            {
                Instantiate(YellowBulletNormal, Firepoint.transform.position, Quaternion.identity);
                
                isShootYellowBall = false;
            }
        }
        else
        {
            isYellowNormal = false;
        }

        //blue
        

        if (other.tag == "BlueNormalBall" && isButton)
        {
            Destroy(other.gameObject);
            isButton = false;
            isShootBlueBall = true;
            if (isShootBlueBall)
            {
                Instantiate(BlueBulletNormal, Firepoint.transform.position, Quaternion.identity);
               
                isShootBlueBall = false;
            }

        }
        else
        {
            isBlueNormal = false;
        }

        //rainbow

        if (other.tag=="BombBall" && isButton)
        {
            Destroy(other.gameObject);
            isButton = false;
            isShootBombBall = true;
            if (isShootBombBall)
            {
                Instantiate(BombBall, Firepoint.transform.position, Quaternion.identity);
                isBombBall = false;
            }
        }
    }
}
