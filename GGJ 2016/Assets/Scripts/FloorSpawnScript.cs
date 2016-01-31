using UnityEngine;
using System.Collections;

public class FloorSpawnScript : MonoBehaviour {

    public GameObject obj;
    public float spawnRate = 1.0f;

    void Start()
    {
        Spawn();
    }

    void Spawn()
    {
        Instantiate(obj, transform.position, Quaternion.identity);
        Invoke("Spawn", spawnRate);
    }
}
