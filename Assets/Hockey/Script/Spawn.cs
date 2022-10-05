using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject RedPrefab;

    void Start()
    {
        Vector3 randomSpawnPosition = new Vector3(Random.Range(-20, 24), 0.15f, Random.Range(-12, 12));
        Instantiate(RedPrefab, randomSpawnPosition, Quaternion.identity);
    }
}
