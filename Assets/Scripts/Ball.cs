using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    public bool inPlay = false;
    private Rigidbody rigidBody;
    private AudioSource audioSource;

    public Vector3 launchVector;

	// Use this for initialization
	void Start ()
    {
        audioSource = GetComponent<AudioSource>();
        rigidBody = GetComponent<Rigidbody>();
        rigidBody.useGravity = false;
    }

    public void Launch(Vector3 velocity)
    {
        inPlay = true;
        rigidBody.useGravity = true;
        rigidBody.velocity = velocity;
        audioSource.Play();
    }

    // Update is called once per frame
    void Update () {
		
	}
}
