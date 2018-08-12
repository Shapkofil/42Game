using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehavior : MonoBehaviour {

    public Vector2 moveDir;
    public float speed;

    public float exparationDate = 12f;
    public float todayDate;

    public Rigidbody2D rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        todayDate = Time.time;
	}
	

    void Update()
    {
       
    }

	// Update is called once per frame
	void FixedUpdate () {
        rb.MovePosition(rb.position + moveDir*speed);
        if (todayDate + exparationDate <= Time.time) Destroy(gameObject);
	}

}
