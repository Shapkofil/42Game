using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrainlessarcherController : MonoBehaviour {

    public Rigidbody2D target;
    public float speed = 0.1f;
    public float distanseToTarget = 4f;

    Rigidbody2D rb;

    public Vector2 MoveDir;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveDir = (target.position - rb.position).normalized;
        MoveDir.x = Mathf.Round(MoveDir.x);
        MoveDir.y = Mathf.Round(MoveDir.y);
        if(Vector2.Distance(target.position , rb.position)<distanseToTarget)
        {
            MoveDir = Vector2.zero;
        }
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + MoveDir * speed);
    }
}
