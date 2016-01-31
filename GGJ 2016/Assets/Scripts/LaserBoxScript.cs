using UnityEngine;
using System.Collections;

public class LaserBoxScript : MonoBehaviour {

    public GameObject obj;
    public float spawnRate = 1.0f;

    void Start()
    {
        Spawn();
    }

    void Spawn()
    {
        Vector3 pos = transform.position;
        pos.y -= obj.GetComponent<Renderer>().bounds.size.y / 2;

        Instantiate(obj, pos, Quaternion.identity);
        Invoke("Spawn", spawnRate);
    }
}
