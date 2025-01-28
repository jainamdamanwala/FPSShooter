using UnityEngine;

public class MapManager : MonoBehaviour
{
    public GameObject[] mapPrefabs;
    public Transform[] spawnPoints;

    void Start()
    {
        SpawnMap();
    }

    void SpawnMap()
    {
        foreach (var point in spawnPoints)
        {
            GameObject mapPiece = mapPrefabs[Random.Range(0, mapPrefabs.Length)];
            Instantiate(mapPiece, point.position, Quaternion.identity);
        }
    }
}
