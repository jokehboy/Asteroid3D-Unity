using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AteroidSplit : MonoBehaviour {

    public GameObject AsterSplit;
    public float randSpawnRad;
    public float randForce;
    public bool lastSpit = true;

    


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


	}

    public void AsteroidDiv()
    {
        if (lastSpit == false)
        {
            Instantiate(AsterSplit, transform.position + Random.insideUnitSphere * randSpawnRad, Quaternion.identity);
            AsterSplit.GetComponent<Rigidbody>().AddForceAtPosition(new Vector3(Random.Range(1, randForce), Random.Range(1, randForce), Random.Range(1, randForce)), new Vector3(Random.value, Random.value, Random.value));

            Instantiate(AsterSplit, transform.position + Random.insideUnitSphere * randSpawnRad, Quaternion.identity);
            AsterSplit.GetComponent<Rigidbody>().AddForceAtPosition(new Vector3(Random.Range(1, randForce), Random.Range(1, randForce), Random.Range(1, randForce)), new Vector3(Random.value, Random.value, Random.value));
            Destroy(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

}
