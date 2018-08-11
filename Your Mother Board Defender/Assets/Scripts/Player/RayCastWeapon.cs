using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastWeapon : MonoBehaviour {


    public Vector2 shootDir = Vector2.zero;
    public float speed;

    public Rigidbody2D rb;
    public Collider2D collider;

    public Object projectile;

    public float fireRate;
    public float timeSince;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        collider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        shootDir = new Vector2(Input.GetAxisRaw("Fire Horizontal"), Input.GetAxisRaw("Fire Vertical"));

        if (shootDir != Vector2.zero && timeSince + fireRate <= Time.time)
        {
            GameObject clone = Instantiate(projectile,transform.position,Quaternion.identity)as GameObject;
            clone.GetComponent<Rigidbody2D>().AddForce(shootDir*10000);

            timeSince = Time.time;

            RaycastHit2D[] rayhits = new RaycastHit2D[20];

            int n =collider.Raycast(shootDir,rayhits);

            for(int i=0;i<n;i++)
            {
                if(rayhits[i].collider.tag=="Enemy")
                {
                    Stats st = rayhits[i].collider.gameObject.GetComponent<Stats>();
                    st.DamagePlayer(1);
                }
            }

        }

    }

    void FixedUpdate()
    {

    }
}
