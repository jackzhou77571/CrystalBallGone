using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StonePoint : MonoBehaviour {
    public Sprite[] colorstone;
    public Image colorimagegreen;
    public Image colorimageyellow;
    public Image colorimageblue;


    public GameObject[] stone;


    
    public int greenPoint = 0;
    public int yellowPoint = 0;
    public int bluePoint = 0;
    public static StonePoint instance;

    
    // Use this for initialization
    

    void Awake()
    {
        instance = this;
    }

    void Start () {
        greenPoint = 0;
        yellowPoint = 0;
        bluePoint = 0;
      
    }
	
	// Update is called once per frame
	void Update () {
        switch (greenPoint)
        {
            case 0:
                colorimagegreen.sprite = colorstone[12];
                break;
            case 1:
                colorimagegreen.sprite = colorstone[4];
                break;
            case 2:
                colorimagegreen.sprite = colorstone[5];
                break;
            case 3:
                colorimagegreen.sprite = colorstone[5];
                break;
            case 4:
                colorimagegreen.sprite = colorstone[6];
                break;
            case 5:
                colorimagegreen.sprite = colorstone[6];
                break;
            case 6:
                colorimagegreen.sprite = colorstone[7];
                break;
           
               

        }

        switch (yellowPoint)
        {
            case 0:
                colorimageyellow.sprite = colorstone[12];
                break;
            case 1:
                colorimageyellow.sprite = colorstone[8];
                break;
            case 2:
                colorimageyellow.sprite = colorstone[9];
                break;
            case 3:
                colorimageyellow.sprite = colorstone[9];
                break;
            case 4:
                colorimageyellow.sprite = colorstone[10];
                break;
            case 5:
                colorimageyellow.sprite = colorstone[10];
                break;
            case 6:
                colorimageyellow.sprite = colorstone[11];
                break;
           
                
        }

        switch (bluePoint)
        {
            case 0:
                colorimageblue.sprite = colorstone[12];
                break;
            case 1:
                colorimageblue.sprite = colorstone[0];
                break;
            case 2:
                colorimageblue.sprite = colorstone[1];
                break;
            case 3:
                colorimageblue.sprite = colorstone[1];
                break;
            case 4:
                colorimageblue.sprite = colorstone[2];
                break;
            case 5:
                colorimageblue.sprite = colorstone[2];
                break;
            case 6:
                colorimageblue.sprite = colorstone[3];
                break;
            
              
        }

    }



   

   public void AddScoreGreen()
    {
        if (greenPoint<6)
        {
            greenPoint += 1;
        }
        else
        {
            greenPoint = 6;
        }
       
    }
    public void subtractionScoreGreen()
    {
        if (greenPoint > 0)
        {
            greenPoint -= 1;
        }
        else
        {
            greenPoint = 0;
        }

    }


    public void AddScoreYellow()
    {
        if (yellowPoint < 6)
        {
            yellowPoint += 1;
        }
        else
        {
            yellowPoint = 6;
        }

    }
    public void subtractionScoreYellow()
    {
        if (yellowPoint > 0)
        {
            yellowPoint -= 1;
        }
        else
        {
            yellowPoint = 0;
        }

    }

    public void AddScoreBlue()
    {
        if (bluePoint < 6)
        {
            bluePoint += 1;
        }
        else
        {
            bluePoint = 6;
        }

    }
    public void subtractionScoreBlue()
    {
        if (bluePoint > 0)
        {
            bluePoint -= 1;
        }
        else
        {
            bluePoint = 0;
        }

    }
}
