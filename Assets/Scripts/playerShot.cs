using UnityEngine;
using System.Collections;

public class playerShot : MonoBehaviour {

	private float speed = 12.0f;
	private float lifeTime = 1.5f;
	private Rigidbody2D rb;

	void Start () {
	
		rb = GetComponent<Rigidbody2D> ();
		rb.velocity = new Vector2 (speed, 0);

		Destroy (this.gameObject, lifeTime);
	}

}
