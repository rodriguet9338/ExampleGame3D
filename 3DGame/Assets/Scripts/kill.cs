using UnityEngine;
using System.Collections;

public class kill : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		other.gameObject.transform.Translate (0, 5, 5);
	}
}
