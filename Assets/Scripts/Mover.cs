using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {
	public float speed;
	Rigidbody rigidbody;

	// Use this for initialization
	void Start () {
		rigidbody = GetComponent<Rigidbody>();
		rigidbody.velocity = transform.forward * speed;

	}

}
