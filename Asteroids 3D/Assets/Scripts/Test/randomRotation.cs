using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomRotation : MonoBehaviour {

    public float rotRange;
    Vector3 randRot;

	// Use this for initialization
	void Start () {
        randRot.x = Random.Range(-rotRange, rotRange);
        randRot.y = Random.Range(-rotRange, rotRange);
        randRot.z = Random.Range(-rotRange, rotRange);
    }
	
	// Update is called once per frame
	void Update () {

        transform.Rotate(randRot * Time.deltaTime);

	}
}
