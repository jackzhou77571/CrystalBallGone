using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stupbutton : MonoBehaviour {
    public GameObject quitbutton;
    public bool isStop = true;
    
    gameManager gamemanager;
    public static stupbutton instance;
    // Use this for initialization
    public AudioClip musiconplay;
    public AudioClip musiconmenu;
    AudioSource musicplayer;
    void Awake()
    {
        instance = this;
    }

    void Start () {
        musicplayer = GetComponent<AudioSource>();
        musicplayer.clip = musiconplay;
        musicplayer.Play();
    }
	
	// Update is called once per frame
	void Update () {
        
	}

    public void StopGame()
    {
        if (!isStop)
        {
            Time.timeScale = 0;
            isStop = true;
            quitbutton.SetActive(true);
            musicplayer.clip = musiconmenu;
            musicplayer.Play();
        }
        else {
            Time.timeScale = 1;
            isStop = false;
            quitbutton.SetActive(false);
            musicplayer.clip = musiconplay;
            musicplayer.Play();
        }
    }
}
