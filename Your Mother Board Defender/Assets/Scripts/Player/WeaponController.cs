using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour {


    public Vector2 shootDir = Vector2.zero;
    public float speed;

    public Rigidbody2D rb;

    public Object projectile;

    public float fireRate;
    public float timeSince;

    public float rustTime =6f;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        shootDir= new Vector2(Input.GetAxisRaw("Fire Horizontal"), Input.GetAxisRaw("Fire Vertical"));

        if(shootDir != Vector2.zero && timeSince+fireRate<=Time.time)
        {
            timeSince = Time.time;

            GameObject clone = Instantiate(projectile, rb.position, Quaternion.identity ) as GameObject;
            ProjectileBehavior behavior = clone.AddComponent(typeof(ProjectileBehavior)) as ProjectileBehavior;

            behavior.moveDir = shootDir;
            behavior.speed = speed;
            behavior.exparationDate = rustTime;

        }

	}

    void FixedUpdate()
    {

    }
}
