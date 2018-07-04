using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCube : MonoBehaviour {
    public GameObject[] StartCubePrefab;
    public float MoveDownSpeed;
    public GameObject cubeCreater;
    CubeCreaterController cubecreatercontroller;
	// Use this for initialization
	void Start () {
        CreateStartCube();
        cubecreatercontroller = cubeCreater.GetComponent<CubeCreaterController>();
    }
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y > 4.5)
        {
            transform.Translate( Vector2.down * Time.deltaTime*MoveDownSpeed);

        }

        if (transform.position.y<6)
        {
            cubecreatercontroller.enabled = true;
        }
	}

    private void CreateStartCube ()
    {

        for (int i = 0; i < 18; i++)
        {
            Vector3 pos = new Vector3(transform.position.x, (i*0.3f)+12,0);
            GameObject startcubep = GameObject.Instantiate(StartCubePrefab[Random.Range(0, 3)], pos, Quaternion.identity);
            startcubep.GetComponent<Transform>().SetParent(gameObject.transform);
        }
    }
}
