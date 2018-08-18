using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSphere : MonoBehaviour {
	Vector3 movement;
	// Use this for initialization
	void Start () {
		movement = new Vector3 (100, 75, 50);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (movement * Time.deltaTime);
	}
}
