using UnityEngine;
using System.Collections.Generic;

public class ScoreDisplayer : MonoBehaviour {

	int score;
	GUIStyle guiStyle;
	bool guiStyleSetup=false;
	float elapsedTime;

	public float spawnTime;
	public Transform[] prefab_list = new Transform[4];
	//Object[] createdObjects = new Object[10];
	List<Object> created_objects = new List<Object>();

	void OnGUI() 
	{
		if (guiStyleSetup == false) 
		{
			guiStyle = new GUIStyle (GUI.skin.label); 
			guiStyle.fontSize = 50;
			guiStyle.normal.textColor = Color.black;
			guiStyleSetup = true;
		}
		GUI.Label (new Rect (10, 10, 400, 400), "Score: " + score,guiStyle);
	}

	public void updateScore(int change)
	{
		score += change;
	}
		
	// Use this for initialization
	void Start ()
	{	
		//get component from another
//		OtherScript os = GetComponent<OtherScript>();
//		os.doSomethingCool ();

		InvokeRepeating ("Spawn", spawnTime, spawnTime);

//		elapsedTime += Time.deltaTime;
//		if (elapsedTime > 3.0f) {
//			Camera c = GetComponent<Camera> ();
//			c.clearFlags = CameraClearFlags.Color;
//			c.backgroundColor = Color.red;
//		}
		//scoring
		score = 0;

	}

	void Spawn(){
		//prefab
		foreach (var prefab_object in prefab_list) {
			Object g = Instantiate(prefab_object, new Vector3(Random.Range (-14.0f, 14.0f), Random.Range (-10.0f, 10.0f), 10), Quaternion.identity);
			created_objects.Add (g);
		}
	}
		
	// Update is called once per frame
	void Update () 
	{
		
	}
}
