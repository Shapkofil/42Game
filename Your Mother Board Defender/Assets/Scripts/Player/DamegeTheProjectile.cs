using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamegeTheProjectile : MonoBehaviour {


    void OnCollisionEnter2D(Collision2D collision)
    {
        Collider2D other = collision.collider;
        if(other.tag=="Enemy")
        {
            Debug.Log("K");
            Stats st = other.gameObject.GetComponent<Stats>();
            st.DamagePlayer(1);
            Destroy(gameObject);
        }
    }
}
