using System;
using UnityEngine;

namespace Physics
{
	public static class Collision
	{
		public static bool IsSelected(Collider2D collider2D)
		{
			if (Input.GetMouseButtonDown (0)) 
			{
				Vector3 wp = Camera.main.ScreenToWorldPoint (Input.mousePosition);
				Vector2 clickPos = new Vector2 (wp.x, wp.y);
				return collider2D == Physics2D.OverlapPoint (clickPos);
			}
			if (Input.touchCount ==1)
			{
				Vector3 wp = Camera.main.ScreenToWorldPoint (Input.GetTouch(0).position);
				Vector2 touchPos = new Vector2 (wp.x, wp.y);
				return collider2D == Physics2D.OverlapPoint (touchPos);
			}
			return false;
		}
	}
}