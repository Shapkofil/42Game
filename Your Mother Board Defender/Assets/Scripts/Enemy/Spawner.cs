using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public Object enemy;
    public Rigidbody2D target;
    public Transform[] spawnPoint;

    public float spawnRate = 4;
    float timeAlways;

    void Spawn(Vector3 point)
    {
        GameObject clone = Instantiate(enemy, point, Quaternion.identity) as GameObject;
        clone.GetComponent<BrainlessarcherController>().target = target;
    }

    void Start()
    {
        timeAlways = Time.time;
    }

    void Update()
    {
        if (timeAlways + spawnRate <= Time.time)
        {
            timeAlways = Time.time;
            Spawn(spawnPoint[(int)Random.Range(0,2)].position);
        }
    }
}
