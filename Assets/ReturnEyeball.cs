	using UnityEngine;
using System.Collections;

public class ReturnEyeball : MonoBehaviour {

	public GameObject movingEye;
	public GameObject player;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider other) {
		if(other.gameObject == movingEye) {
			other.gameObject.transform.SetParent(player.transform);
			//other.gameObject.GetComponent<CharacterMovement>().dropEye(Vector3())
			movingEye.GetComponent<EyeballMovement>().conveyorBelt = false;
			Debug.Log(other.gameObject.transform.parent);			
		}
		else {
			Debug.Log(other);
		}
	}

	void OnTriggerStay(Collider other) {
		if(Input.GetKeyDown(KeyCode.E)) {
			Debug.Log("Returning");
			EyeballMovement buddy = other.gameObject.GetComponent<EyeballMovement>();
			Vector3 returnPos = buddy.startPos;
			buddy.dropEye(returnPos);
			//player.GetComponent<CharacterMovement>().dropEye(returnPos);
		}
	}
}
