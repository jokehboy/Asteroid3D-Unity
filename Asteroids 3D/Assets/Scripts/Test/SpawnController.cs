using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour {

    EnemySpawn enemySpawn;
    public GameObject[] spawnPoints;
    public int spawnCount;
    public int spawnLimit;
    public int difficultyLvl = 1;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (difficultyLvl == 1)
        {

            if (spawnCount <= spawnLimit)
            {

                int randNo = Random.Range(0, spawnPoints.Length);
                var selectedSpawn = spawnPoints[randNo].GetComponent<EnemySpawn>();

                if (selectedSpawn.spawning == false)
                {
                    
                    spawnPoints[randNo].GetComponent<EnemySpawn>().SpawnEnemy();
                    ++spawnCount;
                }
            }

        }
	}
}
