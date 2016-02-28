using UnityEngine;
using System.Collections;
using UnityEngine.VR;

public class CharacterMovement : MonoBehaviour {

	public GameObject rightEye;
	public GameObject leftEye;
	public Canvas rightBlinder;
	public Canvas leftBlinder;
	public float eyeDropSpeed;
	CharacterController controller;
	private Camera mainEye;
	// Use this for initialization
	void Start () {

		VRSettings.renderScale = 0.3f;
		controller = GetComponent<CharacterController>();
		rightBlinder.enabled = false;
		leftBlinder.enabled = false;
		mainEye = leftEye.GetComponentInChildren<Camera>();
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

		}
	}

	public void dropEye(Vector3 targetPos) {
		StartCoroutine(eyeMovement(targetPos));
	}

	IEnumerator eyeMovement(Vector3 targetPos) {
		Vector3 startPos = rightEye.transform.position;
		float t = 0f;
		while(t <= 1.0f) {
			rightEye.transform.position = Vector3.Lerp(startPos, targetPos, t);
			t += Time.deltaTime/eyeDropSpeed;
			yield return null;
		}
		rightEye.transform.rotation = Quaternion.Euler(0, 270, 0);
		rightEye.transform.parent = null;
		rightEye.GetComponent<EyeballMovement>().conveyorBelt = true;
		rightBlinder.enabled = true;
	}
}
