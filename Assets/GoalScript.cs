using UnityEngine;
using System.Collections;

public class GoalScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void OnTriggerEnter() {
		GameObject particles = (GameObject)Instantiate(Resources.Load("WinParticles"));
		particles.transform.position = gameObject.transform.position;
	}
}
