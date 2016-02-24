using UnityEngine;
using System.Collections;

public class TargetDoor : MonoBehaviour {

	public GameObject targetDoor;
	public bool unlocking;

	public void doorAction() {
		if(unlocking) {
			unlockDoor();
		}
		else {
			lockDoor();
		}
	}
	public void unlockDoor() {
		targetDoor.GetComponentInChildren<UnlockDoor>().OpenSesame();
	}

	public void lockDoor() {
		targetDoor.GetComponentInChildren<UnlockDoor>().CloseSesame();
	}
}
