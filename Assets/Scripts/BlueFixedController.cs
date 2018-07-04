using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueFixedController : MonoBehaviour {
    public GameObject ExplosionMid;
    public GameObject ExplosionSmall;
    public GameObject ExplosionBig;
    public GameObject ExplosionRainbow;

    public float downMove;
    Rigidbody2D rb;
    float timerun = 0.3f;
    private Vector2 expos;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.tag == "Coin" || col.collider.tag == "ColorBrick")
        {
            return;
        }

        //colorbullet active skill
        if (col.collider.tag == "BlueNormalBullet")//Blue
        {
            Destroy(col.gameObject);
            
            Destroy(this.gameObject);
            
            switch (StonePoint.instance.bluePoint)
            {
                case 0:

                    break;
                case 1:
                    Instantiate(ExplosionSmall, transform.position, Quaternion.identity);
                    break;
                case 2:
                    Instantiate(ExplosionSmall, transform.position, Quaternion.identity);
                    break;
                case 3:
                    Instantiate(ExplosionMid, transform.position, Quaternion.identity);
                    break;
                case 4:
                    Instantiate(ExplosionMid, transform.position, Quaternion.identity);
                    break;
                case 5:
                    Instantiate(ExplosionMid, transform.position, Quaternion.identity);
                    break;
                case 6:
                    Instantiate(ExplosionBig, transform.position, Quaternion.identity);
                    break;

            };
            ScoreText.scoreValue += 2 * TimeScript.Level;
            StonePoint.instance.bluePoint = 0;
        }
        else if (col.collider.tag == "YellowNormalBullet" || col.collider.tag == "GreenNormalBullet" )
        {// punish

            Destroy(col.gameObject);

            rb.transform.position = new Vector2(rb.transform.position.x, rb.transform.position.y - downMove);

        }

        //normalbullet active skill
        if (col.collider.tag == "RainbowBullet")//Blue
        {

            Destroy(col.gameObject);
            Destroy(this.gameObject);
            Instantiate(ExplosionRainbow, transform.position, Quaternion.identity);
        }

    }
}
