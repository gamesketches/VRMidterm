using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour {

	public GameObject rightEye;
	public GameObject leftEye;
	public Canvas rightBlinder;
	public Canvas leftBlinder;
	CharacterController controller;
	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController>();
		rightBlinder.enabled = false;
		leftBlinder.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		float hori = Input.GetAxis("Horizontal");
		float vert = Input.GetAxis("Vertical");

		controller.Move(transform.forward * vert + Physics.gravity);
		transform.Rotate(0f, hori * 2f, 0f);

		if(Input.GetKeyDown(KeyCode.Space) == true && rightEye.transform.parent == null) {
			leftBlinder.enabled = !leftBlinder.enabled;
			rightBlinder.enabled = !rightBlinder.enabled;

		}
	}

	public void dropEye(Vector3 targetPos) {
		rightEye.transform.position = targetPos;
		rightEye.transform.rotation = Quaternion.Euler(0, 270, 0);
		rightEye.transform.parent = null;
		rightBlinder.enabled = true;
	}
}
