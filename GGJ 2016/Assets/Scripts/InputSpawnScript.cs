using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class InputSpawnScript : MonoBehaviour {

    public GameObject obj;
    public string inputAccess = "Fire1";

    private void FixedUpdate()
    {
        bool spawn = CrossPlatformInputManager.GetAxis(inputAccess) > 0;

        if (spawn)
        {
            Instantiate(obj, transform.position, Quaternion.identity);
        }
    }
}
