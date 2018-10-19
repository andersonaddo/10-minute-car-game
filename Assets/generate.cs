using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generate : MonoBehaviour {

    public GameObject obstacle;
    public float waitTIme;

	// Use this for initialization
	void Start () {
        StartCoroutine("DoStuff");
	}
	
    IEnumerator DoStuff()
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTIme);
            GameObject gg = Instantiate(obstacle, transform.position, Quaternion.identity);
            gg.transform.Translate(Vector3.left * Random.Range(-3, 4));
        }
    }
}
