﻿using UnityEngine;
using System.Collections;

public class Scroll : MonoBehaviour {

	public float speed = 0.1f;

	void Start () {

	}

	void Update () {
	

		float x = Mathf.Repeat (Time.time * speed, 1);

		Vector2 offset = new Vector2 (x , 0);

		GetComponent<Renderer> ().sharedMaterial.SetTextureOffset ("_MainTex", offset);
	}
}
