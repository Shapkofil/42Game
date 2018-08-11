using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {

    public float givenTime = 6.0f;
    float nowTime;
	// Use this for initialization
	void Start () {
        nowTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
        if (nowTime + givenTime <= Time.time) Destroy(gameObject);
	}
}
