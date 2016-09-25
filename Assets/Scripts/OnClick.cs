using UnityEngine;
using System.Collections;

public class OnClick : MonoBehaviour {
	private ScoreDisplayer score_displayer;
	public int object_score;

	// Use this for initialization
	void Start () {
		GameObject gameControllerObject = GameObject.FindWithTag ("ScoreDisplayer");
		if (gameControllerObject != null)
		{
			score_displayer = gameControllerObject.GetComponent <ScoreDisplayer>();
		}
		if (score_displayer == null)
		{
			Debug.Log ("Cannot find 'ScoreDisplayer' script");
		}
	}
	
	// Update is called once per frame
	private float time = 0;
	void Update () {
		time += Time.deltaTime;
		if (time > 15.0f) {
			Destroy (this.gameObject);
		}
	}

	void OnMouseDown(){
		score_displayer.updateScore (object_score);
		Destroy (this.gameObject);
	}

	void OnMouseOver(){
		transform.Rotate (0, 10, 0);
	}
}
