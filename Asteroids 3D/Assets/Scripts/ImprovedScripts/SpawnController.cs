using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour {

    Spawn Spawn;
    public GameObject Spawner;
    
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

            if (spawnCount < spawnLimit && !Spawner.GetComponent<Spawn>().spawning)
            {

                Spawner.GetComponent<Spawn>().SpawnEnemy();
                
            }

        }
	}

    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(0, 0, 1, 0.5f);
        Gizmos.DrawSphere(transform.localPosition, 20);
    }

}
