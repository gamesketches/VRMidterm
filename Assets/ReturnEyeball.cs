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
		Debug.Log(other);
		if(other.gameObject == movingEye) {
			//other.gameObject.transform.parent = player.transform;
			movingEye.GetComponent<EyeballMovement>().conveyorBelt = false;
		}
		else {
			Debug.Log(other);
		}
	}
}
