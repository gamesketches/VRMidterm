using UnityEngine;
using System.Collections;

public class UnlockDoor : MonoBehaviour {

	public float totalMovement;
	// Use this for initialization
	void Start () {
	
	}
	
	public void OpenSesame() {
		StartCoroutine(open());
	}

	IEnumerator open() {
		Vector3 target = transform.position + new Vector3(0.0f, totalMovement, 0.0f);
		while(transform.position.y <= target.y) {
			transform.position = new Vector3(transform.position.x, transform.position.y + (1.0f * Time.deltaTime), transform.position.z);
			yield return null;
		}
	}
}
