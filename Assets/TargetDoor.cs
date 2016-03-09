using UnityEngine;
using System.Collections;

public class TargetDoor : MonoBehaviour {

	public GameObject targetDoor;
	public bool unlocking;

	public void doorAction() {

		Debug.Log("Unlocking");
		gameObject.GetComponent<Renderer>().material.color = Color.blue;
		if(unlocking) {
			unlockDoor();
		}
		else {
			Debug.Log("PROGRAMMING");
		}
	}
	public void unlockDoor() {
		targetDoor.GetComponentInChildren<UnlockDoor>().OpenSesame();
	}

	public void lockDoor() {
		targetDoor.GetComponentInChildren<UnlockDoor>().CloseSesame();
	}
}
