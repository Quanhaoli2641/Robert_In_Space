using UnityEngine;
using System;

public class EdgeCollider2DEditor : MonoBehaviour {

	public int numPoints = 1000;
	EdgeCollider2D edge;

	void Start(){
		edge = gameObject.GetComponent<EdgeCollider2D> ();
		Vector2[] verticies = edge.points;
		for(int i = 0; i < numPoints; i++){
			float x = (float)(0.5 * Math.Cos (i * 2 * Math.PI / numPoints));
			float y = (float)(0.5 * Math.Sin (i * 2 * Math.PI / numPoints));
			verticies[i] = new Vector2 (x, y);
		}
		edge.points = verticies;
	}

}
