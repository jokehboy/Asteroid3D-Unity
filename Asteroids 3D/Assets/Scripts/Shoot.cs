using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    public GameObject projectile;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bullet = Instantiate(projectile, transform.position, Quaternion.identity);
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);

            new WaitForSeconds(5f);
            Destroy(bullet, 5f);
        }

	}


}
