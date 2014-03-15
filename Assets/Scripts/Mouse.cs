using UnityEngine;
using System.Collections;

public class Mouse : MonoBehaviour {
	private float timeElapsed = 0;
	private float interval = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timeElapsed += Time.deltaTime;
		if (timeElapsed > interval) {
			timeElapsed = 0;
			Status.Food += 1;
		}
	}
}
