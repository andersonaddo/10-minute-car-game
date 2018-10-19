using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class drive : MonoBehaviour {

    public float speed, rotSpeed, maxAngle;

    float z;
	
	// Update is called once per frame
	void Update () {
        transform.Translate(transform.up * Time.deltaTime * speed);
        z -= Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;

        z = Mathf.Clamp(z, -maxAngle, maxAngle);
        transform.localRotation = Quaternion.Euler( new Vector3(0, 0, z));
	}

    void OnTriggerEnter2D()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
