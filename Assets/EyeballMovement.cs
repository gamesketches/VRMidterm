using UnityEngine;
using System.Collections;

public class EyeballMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(gameObject.transform.parent == null) {
			Vector3 newPos = new Vector3(transform.position.x, transform.position.y, transform.position.z - (1 * Time.deltaTime));
			transform.position = newPos;
		}
	}
}
