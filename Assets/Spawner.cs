using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public Transform[] teleport;
    public GameObject[] prefab;
    public Canvas canvas;
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.K))
        {
            int tele_num = Random.Range(0, 1);
            int prefab_num = Random.Range(0, 9);

            

            prefab[prefab_num].transform.SetParent(canvas.transform,false);
        }
	}
}
