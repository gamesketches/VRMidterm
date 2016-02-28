using UnityEngine;
using System.Collections;

public class EyeballMovement : MonoBehaviour {

	public bool conveyorBelt;
	public Vector3 startPos;
	public float eyeDropSpeed;
	private Canvas rightBlinder;
	delegate void SocketFunction();
	private SocketFunction socketingFunction;
	// Use this for initialization
	void Start () {
		conveyorBelt = false;
		startPos = transform.localPosition;
		rightBlinder = GetComponentInChildren<Canvas>();
		Debug.Log(startPos);
	}
	
	// Update is called once per frame
	void Update () {
		if(conveyorBelt) {
			Vector3 newPos = new Vector3(transform.position.x, transform.position.y, transform.position.z - (1 * Time.deltaTime));
			transform.position = newPos;
		}
	}

	public void dropEye(Vector3 targetPos) {
		StartCoroutine(eyeMovement(targetPos, leaveSocket));
	}

	public void pickupEye(Vector3 targetPos) {
		StartCoroutine(eyeMovement(targetPos, returnToSocket));
	}

	public IEnumerator detachEye(Vector3 targetPos) {
		Vector3 startPos = transform.position;
		float t = 0f;
		while(t <= 1.0f) {
			transform.position = Vector3.Lerp(startPos, targetPos, t);
			t += Time.deltaTime/eyeDropSpeed;
			yield return null;
		}
		transform.rotation = Quaternion.Euler(0, 270, 0);
		transform.parent = null;
		conveyorBelt = true;
		rightBlinder.enabled = true;
	}

	public IEnumerator reattachEye() {
		conveyorBelt = false;
		transform.localRotation = Quaternion.Euler(Vector3.forward);
		rightBlinder.enabled = false;
		Vector3 initialPos = transform.localPosition;
		float t = 0f;
		while(t <= 1.0f) {
			transform.localPosition = Vector3.Lerp(initialPos, startPos, t);
			t += Time.deltaTime/eyeDropSpeed;
			yield return null;
		}
	}

	IEnumerator eyeMovement(Vector3 targetPos, SocketFunction socketFunction) {
		Vector3 startPos = transform.position;
		float t = 0f;
		while(t <= 1.0f) {
			transform.position = Vector3.Lerp(startPos, targetPos, t);
			t += Time.deltaTime/eyeDropSpeed;
			yield return null;
		}
		socketFunction();
	}

	void leaveSocket() {
		transform.rotation = Quaternion.Euler(0, 270, 0);
		transform.parent = null;
		conveyorBelt = true;
		rightBlinder.enabled = true;
	}

	void returnToSocket() {
		transform.localRotation = Quaternion.Euler(Vector3.forward);
		rightBlinder.enabled = false;
	}

}
