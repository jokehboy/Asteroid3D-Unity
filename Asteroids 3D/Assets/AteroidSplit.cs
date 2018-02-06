using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AteroidSplit : MonoBehaviour {

    public GameObject AsterSplit;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


	}
        
    public void AsteroidDiv()
        {
            Instantiate(AsterSplit, transform.position + Random.insideUnitSphere *3f , Quaternion.identity);
        AsterSplit.GetComponent<Rigidbody>().AddForceAtPosition(new Vector3(Random.Range(1, 100), Random.Range(1, 100), Random.Range(1, 100)), new Vector3(Random.value, Random.value, Random.value));

            Instantiate(AsterSplit, transform.position + Random.insideUnitSphere*3f , Quaternion.identity);
        AsterSplit.GetComponent<Rigidbody>().AddForceAtPosition(new Vector3(Random.Range(1,100), Random.Range(1, 100), Random.Range(1, 100)), new Vector3(Random.value, Random.value, Random.value));
        Destroy(this.gameObject);
        }

    

}
