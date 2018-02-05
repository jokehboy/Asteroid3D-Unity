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
        if (col.gameObject.tag == "Asteroid1")
        {
            GameObject hit = col.gameObject;
            AteroidSplit split = hit.GetComponent<AteroidSplit>();

            split.AsteroidDiv();
            

            Destroy(this.gameObject);

            
        }


    }
}
