using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardCreaterController : MonoBehaviour {
    public GameObject[] subBoard;
    bool isBoardCreated;
    public float ratetime;
    float nextFire = 0.5f;

    private List<GameObject[]> maplist = new List<GameObject[]>();
    // Use this for initialization
    void Start () {
        CreateBoardItem();

    }
	
	// Update is called once per frame
	void Update () {
          /*
        if (maplist.Count<5)
        {
            CreateBoardItem();
        }
            */

        
	}

    void CreateBoardItem()
    {
        GameObject[] item = new GameObject[20];
        for (int i = 0; i < 20; i++)// pos 距离减少 乘以0.5??
        {
            Vector2 pos = new Vector2(0, i + 20f);
            GameObject subboard = Instantiate(subBoard[Random.Range(0, 3)], pos * 0.44f, Quaternion.identity, gameObject.transform) as GameObject;
            //subboard.transform.parent = gameObject.transform;
            item[i] = subboard;
        }
        maplist.Add(item);
    }

    void OnCollisionExit2D(Collision2D col)
    {
        

       
    }
}
