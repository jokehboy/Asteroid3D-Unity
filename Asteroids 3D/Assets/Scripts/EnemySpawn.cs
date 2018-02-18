using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {

    public GameObject enemyPref;
    
    public float spawnRad;
    public float randForce;
    public float randTorq;
    public bool spawning = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

       
		
	}
    

    public void SpawnEnemy()
    {
        
        spawning = true;
        var spawnedEnemy = Instantiate(enemyPref, transform.position + Random.insideUnitSphere * spawnRad, Quaternion.identity);
        spawnedEnemy.GetComponent<Rigidbody>().AddRelativeForce(Random.onUnitSphere * Random.Range(2000, randForce));
        spawnedEnemy.GetComponent<Rigidbody>().AddRelativeTorque(Random.insideUnitSphere * Random.Range(1000, randTorq));
    }

}
