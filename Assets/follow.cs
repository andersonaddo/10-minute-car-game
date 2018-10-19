using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour {

    public Transform t;
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(transform.position.x, t.position.y, transform.position.z);
	}
}
