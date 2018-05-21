using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoulettController : MonoBehaviour {

    float rotSpeed = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //マウスが押されたらスピードオン
        if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 10;
        }

        //回転速度分、ルーレットの回転
        transform.Rotate(0, 0, this.rotSpeed);

        //ルーレットを減速させる
        this.rotSpeed *= 0.96f;
	}
}
