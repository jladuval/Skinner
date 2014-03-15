using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public static class CircleMath {

	public static ICollection<Vector3> GetNPointsOnCircle(Vector3 centre, float radius, int numMice)
	{		
		var alpha = Mathf.PI * 2 / numMice;
		var points = new List<Vector3>();
		
		for(var i = 0; i < numMice; i++)
		{
			var theta = alpha * i;
			var pointOnCircle = new Vector3( Mathf.Cos( theta ) * radius, Mathf.Sin( theta ) * radius );
			points.Add(centre + pointOnCircle);
		}
		
		return points;
	}
}
