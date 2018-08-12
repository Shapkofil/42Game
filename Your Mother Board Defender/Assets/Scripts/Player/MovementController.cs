using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour {

    public Vector2 moveDir = Vector2.zero;
    public float speed = 0.2f;
    //float nextStep;
    public Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        //nextStep = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
        moveDir = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveDir.Normalize();
	}
    void FixedUpdate()
    { 
            //nextStep = Time.time;
            rb.MovePosition(rb.position + moveDir * speed);
    }
}
