using UnityEngine;
using System.Collections;

public class EyeballMovement : MonoBehaviour {

	public bool conveyorBelt;
	// Use this for initialization
	void Start () {
		conveyorBelt = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(conveyorBelt) {
			Vector3 newPos = new Vector3(transform.position.x, transform.position.y, transform.position.z - (1 * Time.deltaTime));
			transform.position = newPos;
		}
	}
}
