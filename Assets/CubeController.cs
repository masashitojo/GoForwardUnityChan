using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {
	//キューブの移動速度
	private float speed = -12;
	//消滅位置
	private float deadLine= -10;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		//キューブを移動させる
		transform.Translate(this.speed*Time.deltaTime,0,0);
		//transform.Translate(-0.1f,0,0);

		//画面外に出たら破棄する
		if (transform.position.x < this.deadLine) {
			Destroy (gameObject);
		}
	}

	//課題(キューブが地面に接触する時とキューブ同士が積み重なるときに効果音をつける)
	void OnCollisionEnter2D(Collision2D other) {
		//
		if (other.gameObject.tag == "CubeTag" || other.gameObject.tag == "GroundTag") {
			GetComponent<AudioSource> ().Play();
		}
	}
}
