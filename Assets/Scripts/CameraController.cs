using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	private GameObject player;
	private GameObject mainCamera;

	//カメラの移動制限範囲をステージごとに指定
	public float maxX = 20.0f;
	public float minX = -20.0f;
	public float maxY = 3.0f;
	public float minY = -3.0f;


	void Start () {
		player = GameObject.Find ("Player");
		mainCamera = GameObject.Find ("Main Camera");
	}
	

	void Update () {
		//カメラのY軸は-10で固定（Vector3）してプレイヤーを追従
		mainCamera.transform.position = new Vector3 (Mathf.Clamp (player.transform.position.x, minX , maxX),Mathf.Clamp ( player.transform.position.y, minY, maxY),-10);

	}



}
