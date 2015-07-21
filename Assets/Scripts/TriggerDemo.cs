using UnityEngine;
using System.Collections;

public class TriggerDemo : MonoBehaviour {

	public ParticleSystem particles;

	// Use this for initialization
	void Start () {
	
	}
	
	// Whenever an object w/ a rigidbody & collider enters the trigger, this will be called
	void OnTriggerEnter(Collider other){
		particles.Play();
	}

	// Update is called once per frame
	void Update () {

	}
}
