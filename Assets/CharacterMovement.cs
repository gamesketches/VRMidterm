﻿using UnityEngine;
using System.Collections;
using UnityEngine.VR;
using UnityEngine.UI;

public class CharacterMovement : MonoBehaviour {

	public GameObject rightEye;
	public GameObject leftEye;
	public Canvas rightBlinder;
	public Canvas leftBlinder;
	CharacterController controller;
	private Camera mainEye;
	// Use this for initialization
	void Start () {

		VRSettings.renderScale = 0.3f;
		controller = GetComponent<CharacterController>();
		rightBlinder.enabled = false;
		leftBlinder.enabled = false;
		mainEye = leftEye.GetComponentInChildren<Camera>();
		leftEye.GetComponent<Renderer>().enabled = false;
		rightEye.GetComponent<Renderer>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		float hori = Input.GetAxis("Horizontal");
		float vert = Input.GetAxis("Vertical");

		controller.Move(mainEye.transform.forward * vert * Time.deltaTime * 10.0f + Physics.gravity);
		transform.Rotate(0f, hori * 2f, 0f);

		if(Input.GetKeyDown(KeyCode.Space) == true && rightEye.transform.parent == null) {
			leftBlinder.enabled = !leftBlinder.enabled;
			rightBlinder.enabled = !rightBlinder.enabled;
			rightBlinder.GetComponentInChildren<Text>().enabled = false;

		}
	}
		
}
