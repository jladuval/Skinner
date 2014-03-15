using UnityEngine;
using System.Collections;

public class GUI : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GameObject.Find ("Food").guiText.text = Status.Food + " Food";
	}
}
