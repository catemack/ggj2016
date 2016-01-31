using UnityEngine;
using System.Collections;

public class ObstacleScript : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            //Debug.Break();
            Application.Quit();
        }
    }
}