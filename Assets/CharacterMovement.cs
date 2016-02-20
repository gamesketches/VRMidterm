using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour {

	public GameObject rightEye;
	CharacterController controller;
	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
		float hori = Input.GetAxis("Horizontal");
		float vert = Input.GetAxis("Vertical");

		controller.Move(transform.forward * vert + Physics.gravity);
		transform.Rotate(0f, hori * 2f, 0f);
	}

	public void dropEye(Vector3 targetPos) {
		rightEye.transform.position = targetPos;
		rightEye.transform.rotation = Quaternion.Euler(0, 270, 0);
		rightEye.transform.parent = null;
	}
}
