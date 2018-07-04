using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour {
    public GameObject cannon;
    public GameObject gameOverText;
    public GameObject restartButton;
    public GameObject maintoucharea;
    public GameObject goStop;
    public GameObject goMenu;
    
    Fire fire;
    bool gameHasEnded = false;
    // Use this for initialization
   
    void Awake()
    {
        Time.timeScale = 1;
        restartButton.SetActive(false);
        ScoreText.scoreValue = 0;
        gameHasEnded = false;
        //AudioSource.PlayClipAtPoint(playmusic, transform.position);
    }
    void Start () {
        fire = cannon.GetComponent<Fire>();

        goMenu.SetActive(false);

    }
	
	// Update is called once per frame
	void Update () {
        //TouchScreen();
      
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag=="ColorBrick")
        {
            if (!gameHasEnded)
            {
                gameHasEnded = true;
                GameOver();
                
                
                Time.timeScale = 0;
            }
          
            
        }
    }

   public  void Restart()
    {
        Time.timeScale = 1;
        ScoreText.scoreValue = 0;
        TimeScript.Level = 1;
        SceneManager.LoadScene("Main");
        
    }


    void GameOver()
    {
        Time.timeScale = 0;
        gameOverText.SetActive(true);
        restartButton.SetActive(true);
        maintoucharea.SetActive(false);
        goStop.SetActive(false);
        goMenu.SetActive(true);
        
    }

    void TouchScreen()
    {
        if (Input.touchCount == 1)
        {
            print(Input.touchCount);
            if (Input.touches[0].phase == TouchPhase.Began)
            {
                fire.isButton = true;

                fire.BulletShoot = true;
                Debug.Log("touch");
            }

            if (Input.touches[0].phase == TouchPhase.Canceled)
            {
                fire.isButton = false;
                fire.BulletShoot = false;
                Debug.Log("notouch");
            }
        }
    }
}
