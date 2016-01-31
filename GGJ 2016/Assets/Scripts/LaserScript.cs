using UnityEngine;
using System.Collections;

public class LaserScript : MonoBehaviour {

    public float lifeTime = 0.25f;
    private float fireTime = 0.0f;
	
	void Update () {
        fireTime += Time.deltaTime;
        if (fireTime >= lifeTime)
        {
            Destroy(gameObject);
        }
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            //Debug.Break();
            Application.Quit();
        }
    }
}
