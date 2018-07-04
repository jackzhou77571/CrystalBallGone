using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueCubeController : MonoBehaviour {
    public GameObject FloatingText;
    public GameObject RainbowCube;
    public GameObject[] CubeFixed;
    public GameObject ExplosionMid;
    public GameObject ExplosionSmall;
    public GameObject ExplosionBig;
    Vector2 pos;
    Color32 Bcolor32 = new Color32(71, 205, 254, 255);
    Color32 wrongcolor32 = new Color32(255, 0, 0, 255);

    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.collider.tag == "Coin" || col.collider.tag == "ColorBrick")
        {
            return;
        }

        
              

        if (col.collider.tag == "BlueNormalBullet")//blue
        {
            
            Destroy(this.gameObject);
            Destroy(col.gameObject);
           
            pos = col.transform.position;
            StonePoint.instance.AddScoreBlue();
            ScoreText.scoreValue += 1 * TimeScript.Level;
            if (FloatingText)
            {
                ShowFloatingText(1 * TimeScript.Level, pos, Bcolor32,true);


            }
        }
        else if (col.collider.tag == "YellowNormalBullet" || col.collider.tag == "GreenNormalBullet")
        {
            Destroy(this.gameObject);
            pos = col.transform.position;
            //transform.position = new Vector2(transform.position.x, transform.position.y - 0.8f);
            ScoreText.scoreValue -= 1 * TimeScript.Level;
            if (FloatingText)
            {
                ShowFloatingText(1 * TimeScript.Level, pos, wrongcolor32, false);


            }

            StonePoint.instance.subtractionScoreBlue();
            Destroy(col.gameObject);
            Instantiate(RainbowCube, transform.position, Quaternion.identity);
           
        }

        if (col.collider.tag == "BombBullet")
        {
           
            Destroy(col.gameObject);
            Destroy(this.gameObject);
            pos = col.transform.position;
            //Instantiate(CubeFixed[Random.Range(0, 3)], transform.position, Quaternion.identity);
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
            if (FloatingText)
            {
                ShowFloatingText(2 * TimeScript.Level, pos, Bcolor32,true);

            }
            StonePoint.instance.bluePoint = 0;
        }

    }

    void ShowFloatingText(int score, Vector2 pos, Color32 Bcolor32,bool isAdd)
    {
        if (isAdd)
        {
            var go = Instantiate(FloatingText, pos, Quaternion.identity);
            go.GetComponent<TextMesh>().text = "+" + score.ToString();
            go.GetComponent<TextMesh>().color = Bcolor32;
            
        }
        else if (!isAdd)
        {
            var go = Instantiate(FloatingText, pos, Quaternion.identity);
            go.GetComponent<TextMesh>().text = "-" + score.ToString();
            go.GetComponent<TextMesh>().color = Bcolor32;
            
        }
        
    }

    
}
