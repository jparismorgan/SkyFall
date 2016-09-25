using UnityEngine;
using System.Collections;

public class Parenter : MonoBehaviour {
	public GameObject otherCube;
	public enum CharacterState{
		walking, running, sleeping,dead
	};
	GameObject[] createdObjects = new GameObject[10];

	// Use this for initialization
	void Start () {
		CharacterState myCurrentState = CharacterState.walking;

		for (int i = 0; i < 10; i++) {
			GameObject g = Instantiate (otherCube);
			float x = Random.Range (0.0f, 10.0f);
			float y = Random.Range (0.0f, 10.0f);
			float z = Random.Range (0.0f, 10.0f);
			createdObjects[i].transform.position = new Vector3 (x, y, z);
		}

	}
	
	// Update is called once per frame
	void Update () {
		float elapsedTime = 0f;
		elapsedTime += Time.deltaTime;

		if (elapsedTime > 5.0f){
			for (int i = 0; i < 10; i++) {
				Destroy (createdObjects [i]);
			}
		}

		if (Input.GetKeyDown("up")){
			print("key was pressed");
			otherCube.transform.SetParent(this.transform);
		}
		if (Input.GetKeyDown("up")){
			print("key was released");
			otherCube.transform.SetParent(null);
		}
	}
}
