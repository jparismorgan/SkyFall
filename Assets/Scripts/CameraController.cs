using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("up")) {
			transform.Translate (0, 0, 1.0f * Time.deltaTime);
		}
		if (Input.GetKey ("down")) {
			transform.Translate (0, 0, -1.0f * Time.deltaTime);
		}
	}
}
