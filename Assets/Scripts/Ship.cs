﻿using UnityEngine;
using System.Collections;

public class Ship : MonoBehaviour {

	public float Speed = 2000;
	public GameObject Bullet;
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		rigidbody2D.velocity = new Vector2(Input.GetAxis("Horizontal")*Speed*Time.deltaTime, Input.GetAxis("Vertical")*Speed*Time.deltaTime);
		if(Input.GetButtonDown("Jump")) shot();				
	}

	void OnTriggerEnter2D(Collider2D other) {
		Debug.Log("uuu");
		if (other.gameObject.tag == "Boundary") Debug.Log("BOOM!");
	}

	void shot()
	{
		Instantiate(Bullet, transform.position, transform.rotation);
	}
}
