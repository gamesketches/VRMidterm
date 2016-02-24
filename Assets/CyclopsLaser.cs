using UnityEngine;
using System.Collections;

public class CyclopsLaser : MonoBehaviour {

	public GameObject targetDoor;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		Ray PsychicRay = new Ray(transform.position, transform.forward);

		if(Physics.Raycast(PsychicRay, out hit, 40f)){
			if(hit.collider.tag == "button"){
				Debug.Log(hit.collider.gameObject.GetComponent<TargetDoor>().targetDoor);
				hit.collider.gameObject.GetComponentInChildren<TargetDoor>().unlockDoor();//GetComponentInChildren<UnlockDoor>().OpenSesame();
				//targetDoor.GetComponentInChildren<UnlockDoor>().OpenSesame();
			}
		}
		Debug.DrawRay(transform.position, transform.forward * 100f);
	}
}
