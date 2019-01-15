using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomGravity : MonoBehaviour {

	public float gravityX;
	public float gravityY;

	void Start () {
		Physics2D.gravity = new Vector2(gravityX, gravityY);
	}

}
