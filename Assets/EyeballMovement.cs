using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EyeballMovement : MonoBehaviour {

	public bool conveyorBelt;
	public Vector3 startPos;
	public float eyeDropSpeed;
	private Canvas rightBlinder;
	private Vector3 currentVelocity;
	delegate void SocketFunction();
	// Use this for initialization
	void Start () {
		conveyorBelt = false;
		startPos = transform.localPosition;
		rightBlinder = GetComponentInChildren<Canvas>();
	}
	
	// Update is called once per frame
	void Update () {
		if(conveyorBelt) {
			Vector3 newPos = transform.position - (currentVelocity * Time.deltaTime);//new Vector3(transform.position.x, transform.position.y, transform.position.z - (1 * Time.deltaTime));
			transform.position = newPos;
			Debug.Log(currentVelocity);
		}
		else if(Input.GetKeyDown(KeyCode.E) && transform.parent == null) {
			transform.SetParent(GameObject.FindGameObjectWithTag("Player").transform);
			StartCoroutine(reattachEye());
		}
	}

	public IEnumerator detachEye(Vector3 targetPos, Vector3 targetDir) {
		if(!conveyorBelt) {			
			Vector3 startPos = transform.position;
			Image blinder = rightBlinder.GetComponentInChildren<Image>();
			Color blinderColor = blinder.color;
			Color targetColor = new Color(blinderColor.r, blinderColor.g, blinderColor.b, 1.0f);
			rightBlinder.enabled = true;
			float t = 0f;
			while(t <= 1.0f) {
				transform.position = Vector3.Lerp(startPos, targetPos, t);
				blinder.color = Color.Lerp(blinderColor, targetColor, t * 3);
				t += Time.deltaTime/eyeDropSpeed;
				yield return null;
			}
			transform.rotation = Quaternion.Euler(0, 270, 0);
			transform.parent = null;
			conveyorBelt = true;
			currentVelocity = targetDir;
		}
	}

	public IEnumerator reattachEye() {
		conveyorBelt = false;
		transform.localRotation = Quaternion.Euler(Vector3.forward);
		Image blinder = rightBlinder.GetComponentInChildren<Image>();
		Color blinderColor = blinder.color;
		Color targetColor = new Color(blinderColor.r, blinderColor.g, blinderColor.b, 0.5f);
		Vector3 initialPos = transform.localPosition;
		float t = 0f;
		while(t <= 1.0f) {
			transform.localPosition = Vector3.Lerp(initialPos, startPos, t);
			blinder.color = Color.Lerp(blinderColor, targetColor, t);
			t += Time.deltaTime/eyeDropSpeed;
			yield return null;
		}
		rightBlinder.enabled = false;
	}

	public void setVelocity(Vector3 newVelocity) {
		currentVelocity = newVelocity;
	}
}
