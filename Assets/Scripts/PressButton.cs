using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PressButton : MonoBehaviour,IPointerUpHandler,IPointerDownHandler {
    public GameObject cannon;
    Fire fire;

    void Update()
    {
       

       

    }
    // Use this for initialization

    public void OnPointerDown(PointerEventData eventData)
    {
        fire.isButton = true;

        fire.BulletShoot = true;
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        fire.isButton = false;
        fire.BulletShoot = false;
    }

    void Start () {
        fire = cannon.GetComponent<Fire>();
	}
	
	// Update is called once per frame
	
}
