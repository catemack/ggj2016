using UnityEngine;
using System.Collections;

public class CameraRunnerScript : MonoBehaviour {

    Vector3 pos;
    public float cameraSpeed = 10.0f;

    void Start ()
    {
        pos = transform.position;
    }
	
	void Update () {
        //transform.position = new Vector3(transform.position.x + 6, 0, -10);
        pos.x += Time.deltaTime * cameraSpeed;
        transform.position = pos;
	}
}
