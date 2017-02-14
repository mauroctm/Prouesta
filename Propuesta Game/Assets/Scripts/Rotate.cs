using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {
	public float angularVelocity = 10.0f;
	private Vector3 axisOfRotation;
	// Use this for initialization
	void Start () {
		axisOfRotation = Random.onUnitSphere;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(axisOfRotation, angularVelocity * Time.smoothDeltaTime);

	}
}
