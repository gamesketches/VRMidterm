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

	public void CloseSesame(){
		StartCoroutine(close());
	}

	IEnumerator open() {
		GameObject opening = (GameObject)Instantiate(Resources.Load("DoorOpen"));
		opening.transform.position = new Vector3(gameObject.transform.position.x,
				gameObject.transform.position.y, gameObject.transform.position.z);
		Vector3 target = transform.position + new Vector3(0.0f, totalMovement, 0.0f);
		while(transform.position.y <= target.y) {
			transform.position = new Vector3(transform.position.x, transform.position.y + (1.0f * Time.deltaTime), transform.position.z);
			yield return null;
		}
		Destroy(opening);
	}

	IEnumerator close() {
		Vector3 target = transform.position + new Vector3(0.0f, -totalMovement, 0.0f);
		while(transform.position.y >= target.y) {
			transform.position = new Vector3(transform.position.x, transform.position.y - (1.0f * Time.deltaTime), transform.position.z);
			yield return null;
		}
	}
}
