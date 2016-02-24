using UnityEngine;
using System.Collections;

public class TargetDoor : MonoBehaviour {

	public GameObject targetDoor;

	public void unlockDoor() {
		targetDoor.GetComponentInChildren<UnlockDoor>().OpenSesame();
	}
}
