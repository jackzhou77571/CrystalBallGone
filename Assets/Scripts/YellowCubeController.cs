using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowCubeController : MonoBehaviour {
    public GameObject FloatingText;
    
    public GameObject[] CubeFixed;
    public GameObject RainbowCube;
    public GameObject ExplosionMid;
    public GameObject ExplosionSmall;
    public GameObject ExplosionBig;
    Vector2 pos;
    Color32 Ycolor32 = new Color32(240, 214, 0, 255);
    Color32 wrongcolor32 = new Color32(255, 0, 0, 255);

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.tag=="Coin" || col.collider.tag == "ColorBrick")
        {
            return;
        }
                

        if (col.collider.tag == "YellowNormalBullet")//yellownormal
        {
           
            Destroy(this.gameObject);
            Destroy(col.gameObject);
           
            pos = col.transform.position;
            StonePoint.instance.AddScoreYellow();
            ScoreText.scoreValue += 1 * TimeScript.Level;
            if (FloatingText)
            {
                ShowFloatingText(1 * TimeScript.Level, pos, Ycolor32,true);


            }
        }
        else  if (col.collider.tag == "GreenNormalBullet" || col.collider.tag == "BlueNormalBullet")
        {
            Destroy(this.gameObject);
            ScoreText.scoreValue -= 1 * TimeScript.Level;
            pos = col.transform.position;
            if (FloatingText)
            {
                ShowFloatingText(1 * TimeScript.Level, pos, wrongcolor32, false);


            }
            StonePoint.instance.subtractionScoreYellow();
            Destroy(col.gameObject);
            Instantiate(RainbowCube, transform.position, Quaternion.identity);
        }

        if (col.collider.tag == "BombBullet")
        {
           
            Destroy(col.gameObject);
            Destroy(this.gameObject);

            pos = col.transform.position;
            switch (StonePoint.instance.yellowPoint)
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
                ShowFloatingText(2 * TimeScript.Level, pos, Ycolor32,true);

            }
            StonePoint.instance.yellowPoint = 0;


        }
    }

    void ShowFloatingText(int score, Vector2 pos, Color32 Bcolor32, bool isAdd)
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
