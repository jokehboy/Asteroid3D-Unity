using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

    //SpawnCheck is used to check id the object is colliding with any objs before instatiation to prevent unwanted clipping/colliding
    //EnemyPrefab is used to spwan the object
    public GameObject EnemyPrefab;
    public GameObject SpawnCheckPrefab;
    public GameObject SpawnContr;
    
    public Vector3 size;
    public Vector3 center;

    public bool spawning = false;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        /////REMOVE UPON COMPLETION
        if (Input.GetKeyDown(KeyCode.Q))
        {
            SpawnEnemy();
        }

        

	}

    public void SpawnEnemy()
    {
            
            Vector3 pos =  transform.position + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));
            var colCheck = Physics.OverlapBox(pos, EnemyPrefab.GetComponent<Collider>().bounds.size / 2);
            spawning = true;

        if (colCheck.Length > 0)
        {
            spawning = false;
            Debug.Log("Spawn Occ");
        }
        else
        {
            var spawnedEnemy = Instantiate(EnemyPrefab, pos, Quaternion.identity);
            spawnedEnemy.GetComponent<Rigidbody>().AddRelativeForce(Random.onUnitSphere * Random.Range(4000, 10000));
            Debug.Log("Checked and Spawning");
            SpawnContr.GetComponent<SpawnController>().spawnCount += 1;
            spawning = false;
        }


    }





    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube(transform.position, size);
    }

}
