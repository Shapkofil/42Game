using System.Collections;
using System.Collections.Generic;
using UnityEngine.Tilemaps;
using UnityEngine;


public class Spawner : MonoBehaviour {

    public Object enemy;
    public Rigidbody2D target;

    public DeadBody deadbody;
    public Tilemap tilemap;

    public float spawnRate = 4;
    float timeAlways;

    void Spawn(Vector3 point)
    {
        GameObject clone = Instantiate(enemy, point, Quaternion.identity) as GameObject;
        clone.GetComponent<BrainlessarcherController>().target = target;
        clone.GetComponent<Stats>().deadbody = deadbody;
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
            int index = (int)Random.Range(0, deadbody.SpawnPoints.Count - 1);
            if (index < 0) index = 0;
            if(deadbody.SpawnPoints.Count!=0)Spawn(deadbody.SpawnPoints[index]);
        }
    }
}
