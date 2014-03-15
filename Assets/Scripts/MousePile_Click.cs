using UnityEngine;
using System.Collections.Generic;

public class MousePile_Click : MonoBehaviour {

	public UnityEngine.Object mousePrefab;

	private int NumMice { get; set; }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
		{
			Vector3 wp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Vector2 touchPos = new Vector2(wp.x, wp.y);
			if (collider2D == Physics2D.OverlapPoint(touchPos))
			{
				CreateMouse();
			}
		}
	}

	public static ICollection<Vector3> GetNPointsOnCircle(Vector3 centre, float radius, int numMice)
	{		
		var alpha = Mathf.PI * 2 / numMice;
		var points = new List<Vector3>();
		
		var i = -1;
		while( ++i < numMice )
		{
			var theta = alpha * i;
			var pointOnCircle = new Vector3( Mathf.Cos( theta ) * radius, Mathf.Sin( theta ) * radius );
			points.Add(centre + pointOnCircle);
		}
		
		return points;
	}
		
	private void CreateMouse(){
		NumMice += 1;
		foreach(var point in GetNPointsOnCircle(new Vector3(0,0,0),1.55f, NumMice)){
			var mouse = Instantiate(mousePrefab, point, Quaternion.identity);
		}		
	}
}
