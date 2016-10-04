using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private Rigidbody2D rb;
	public GameObject pShot;

	private float nextShotTime= 0.3f;
	private float moveSpeed = 5.0f;
	//private float backSpeed = 0.05f;

	public bool canShot = true;


	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}

	void Update () {

		//移動処理
		float x = Input.GetAxisRaw("Horizontal");
		float y = Input.GetAxisRaw ("Vertical");

		Vector2 direction = new Vector2((x * moveSpeed),(y * moveSpeed));

		rb.velocity = direction;


		//弾を撃つ
		if (Input.GetButton ("Fire1")) {
			
			if (canShot) {
				StartCoroutine (Shot ());
			}
		}


	}



	//弾を撃つ
	IEnumerator Shot(){
		canShot = false;
		Instantiate (pShot, transform.position, transform.rotation);
		yield return new WaitForSeconds (nextShotTime);
		canShot = true;
	}


}
