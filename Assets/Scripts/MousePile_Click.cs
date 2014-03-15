using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class MousePile_Click : MonoBehaviour {

	public UnityEngine.Object mousePrefab;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Physics.Collision.IsSelected(collider2D)){
			CreateMouse();
		}
	}
		
	private void CreateMouse(){
		Status.ClickerMouseCount += 1;
		var mice = GameObject.FindGameObjectsWithTag ("Mouse");
		var i = 0;
		foreach(var point in CircleMath.GetNPointsOnCircle(new Vector3(0,0,0),1.55f, Status.ClickerMouseCount)){
			if(i < mice.Length)
				mice[i++].transform.position = point;
			else
				Instantiate(mousePrefab, point, Quaternion.identity);
		}		
	}
}
