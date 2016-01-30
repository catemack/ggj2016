using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {

    public GameObject obj;
    public float spawnRate = 0.5f;
    
	void Start () {
        Spawn();
	}
	
	void Spawn()
    {
        Instantiate(obj, transform.position, Quaternion.identity);
        Invoke("Spawn", spawnRate);
    }
}
