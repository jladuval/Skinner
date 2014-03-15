using UnityEngine;
using System.Collections;

public class ButtonPress : MonoBehaviour {

	private int count = 0;
	private int lastSecond = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		int now = (int)(Mathf.Floor (Time.time));
		if (Input.GetMouseButtonDown(0))
		{
			Vector3 wp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Vector2 touchPos = new Vector2(wp.x, wp.y);
			if (collider2D == Physics2D.OverlapPoint(touchPos))
			{
				Status.Food += 1;
			}


		}
	}
}
