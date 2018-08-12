using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour {

    public float health = 10f;
    public DeadBody deadbody;

    public void DamagePlayer(float damage)
    {
        health -= damage;
    }


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (health <= 0) DewIt();
	}

    public void DewIt()
    {
        deadbody.LeaveCorpse(transform.position);
        Destroy(gameObject);
    }
}
