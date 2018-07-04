using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour {
    Image timeBar;
    public Image timespeedimage;
    public Sprite[] timepanel;
    public float maxTime = 20f;
    float timeLeft;
    bool isSpeed;
    public static int Level = 1;
    
   
	// Use this for initialization
	void Start () {
        timeBar = GetComponent<Image>();
        timeLeft = maxTime;
        Debug.Log(Level);
        
	}
	
	// Update is called once per frame
	void Update () {

        if (timeLeft>0.5)
        {
            isSpeed = true;
            timeLeft -= Time.deltaTime;
            switch (Level)
            {
                case 0:

                    break;
                case 1:
                    timespeedimage.sprite = timepanel[0];
                    break;
                case 2:
                    timespeedimage.sprite = timepanel[1];
                    break;
                case 3:
                    timespeedimage.sprite = timepanel[2];
                    break;
                case 4:
                    timespeedimage.sprite = timepanel[3];
                    break;
                case 5:
                    timespeedimage.sprite = timepanel[4];
                    break;
                case 6:
                    timespeedimage.sprite = timepanel[5];
                    break;

            };

        }

        else
        {
            ReFillTime();
            
            
        }

 	}

    void ReFillTime()
    {
        
        timeLeft = maxTime;
        if (Time.timeScale < 1.4f)
        {
            Time.timeScale += 0.07f;
        }
        Level += 1;
    }


}
