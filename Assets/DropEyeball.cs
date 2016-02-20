using UnityEngine;
using System.Collections;

public class DropEyeball : MonoBehaviour {

	public Vector3 conveyorBeltPos;
	void OnTriggerStay(Collider other) {
		if(Input.GetKey(KeyCode.R)) {
			other.gameObject.GetComponent<CharacterMovement>().dropEye(conveyorBeltPos);
		}
	}
}
