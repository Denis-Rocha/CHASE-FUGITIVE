using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runner : MonoBehaviour
{
    public Transform targetPoint;
    public float speed = 5f;
    public GameObject appearobject;
    public Transform player;

    private bool hasDisapeeared = false;

    private void Update()
    {
        if (hasDisapeeared)
        {

            transform.position = Vector3.MoveTowards(transform.position, targetPoint.position, speed * Time.deltaTime);

            if (Vector3.Distance(transform.position, targetPoint.position) < 0.1f)

            {
                gameObject.SetActive(false);
                hasDisapeeared = false;
            }

        }
        if (Vector3.Distance(player.position, targetPoint.position) <0.1f)

        { appearobject.SetActive(true); 
        }

    }
}
