using System.Collections;
using System.Collections.Generic;
using UnityEngine.Tilemaps;
using UnityEngine;


public class DeadBody : MonoBehaviour {

    public Tilemap tilemap;
    public Tile body;

    public Transform player;

    public List<Vector3> SpawnPoints;

    public float spawnDistance = 6;

    void Start()
    {

    }
    void Update()
    {
        calculateSpawn();
    }
    public void LeaveCorpse(Vector3 _point)
    {

        Vector3Int point =  tilemap.WorldToCell(_point);
        tilemap.SetTile(point,body);
        
    }

    void calculateSpawn()
    {
        SpawnPoints.Clear();
        if (IsValid(player.position + Vector3.up * spawnDistance)) SpawnPoints.Add(player.position + Vector3.up * spawnDistance);
        if (IsValid(player.position + Vector3.down * spawnDistance)) SpawnPoints.Add(player.position + Vector3.down * spawnDistance);
        if (IsValid(player.position + Vector3.left * spawnDistance)) SpawnPoints.Add(player.position + Vector3.left * spawnDistance);
        if (IsValid(player.position + Vector3.right * spawnDistance)) SpawnPoints.Add(player.position + Vector3.right * spawnDistance);

        if (IsValid(player.position + (Vector3.up + Vector3.left) * spawnDistance)) SpawnPoints.Add(player.position + (Vector3.up + Vector3.left) * spawnDistance);
        if (IsValid(player.position + (Vector3.down + Vector3.left) * spawnDistance)) SpawnPoints.Add(player.position + (Vector3.down + Vector3.left) * spawnDistance);
        if (IsValid(player.position + (Vector3.up + Vector3.right) * spawnDistance)) SpawnPoints.Add(player.position + (Vector3.up + Vector3.right) * spawnDistance);
        if (IsValid(player.position + (Vector3.down + Vector3.right) * spawnDistance)) SpawnPoints.Add(player.position + (Vector3.down + Vector3.right) * spawnDistance);
    }
    bool IsValid(Vector3 point)
    {
        if (tilemap.GetTile(tilemap.WorldToCell(point)) != null) return false;

        if (tilemap.GetTile(tilemap.WorldToCell(point)+Vector3Int.up) != null) return false;
        if (tilemap.GetTile(tilemap.WorldToCell(point)+Vector3Int.down) != null) return false;
        if (tilemap.GetTile(tilemap.WorldToCell(point)+Vector3Int.left) != null) return false;
        if (tilemap.GetTile(tilemap.WorldToCell(point)+Vector3Int.right) != null) return false;
      

        return true;
    }
}
