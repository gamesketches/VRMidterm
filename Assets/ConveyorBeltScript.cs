using UnityEngine;
using System.Collections;

public class ConveyorBeltScript : MonoBehaviour {

	private Renderer renderer;
	// Use this for initialization
	void Start () {
		renderer = gameObject.GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
		renderer.material.mainTextureOffset = new Vector2(0f, Time.time * -0.01f);
	}
}
