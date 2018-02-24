using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootCollider : MonoBehaviour {

    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

     void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag=="asteroid1")
        {
            GameObject hit = col.gameObject;
            AteroidSplit split = hit.GetComponent<AteroidSplit>();

            split.AsteroidDiv();
            
            var uiContr = GameObject.FindGameObjectWithTag("uiContr");
            uiContr.GetComponent<UIContr>().currentScore += 5;

            var spawnContr = GameObject.FindGameObjectWithTag("spawnContr");
            spawnContr.GetComponent<SpawnController>().spawnCount -= 1;

            Destroy(this.gameObject);

            
        }

        if(col.gameObject.tag == "asteroid2" || col.gameObject.tag == "asteroid3")
        {
            GameObject hit = col.gameObject;
            AteroidSplit split = hit.GetComponent<AteroidSplit>();

            var uiContr = GameObject.FindGameObjectWithTag("uiContr");
            uiContr.GetComponent<UIContr>().currentScore += 5;

            split.AsteroidDiv();
            Destroy(this.gameObject);

        }


    }
}
