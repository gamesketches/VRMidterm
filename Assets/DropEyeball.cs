using UnityEngine;
using System.Collections;

public class DropEyeball : MonoBehaviour {

	public Vector3 conveyorBeltPos;
	public Vector3 conveyorBeltDirection;
	public bool chainedBelt;
	private EyeballMovement eyeballLogic;

	void OnTriggerEnter(Collider other) {
		other.gameObject.GetComponentInChildren<EyeballMovement>().setVelocity(conveyorBeltDirection);
		if(chainedBelt) {
			eyeballLogic = other.gameObject.GetComponentInChildren<EyeballMovement>();//other.gameObject.GetComponentInChildren<EyeballMovement>().conveyorBelt = true;
		}
	}

	void OnTriggerStay(Collider other) {
		if(other.gameObject.tag == "eyeball" && chainedBelt) {
			eyeballLogic.conveyorBelt = true;
			eyeballLogic.setVelocity(conveyorBeltDirection);
		}
		if(Input.GetKeyDown(KeyCode.E)) {
			StartCoroutine(other.gameObject.GetComponentInChildren<EyeballMovement>().detachEye(conveyorBeltPos, conveyorBeltDirection));
		}
	}

	void OnTriggerExit(Collider other) {
		if(other.gameObject.tag == "eyeball") {
		other.gameObject.GetComponentInChildren<EyeballMovement>().setVelocity(Vector3.zero);
		other.gameObject.GetComponentInChildren<EyeballMovement>().conveyorBelt = false;
		}
	}
}
