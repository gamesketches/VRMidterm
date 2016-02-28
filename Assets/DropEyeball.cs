using UnityEngine;
using System.Collections;

public class DropEyeball : MonoBehaviour {

	public Vector3 conveyorBeltPos;
	void OnTriggerStay(Collider other) {
		if(Input.GetKey(KeyCode.E)) {
			StartCoroutine(other.gameObject.GetComponentInChildren<EyeballMovement>().detachEye(conveyorBeltPos));
		}
	}
}
