using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalaIA : MonoBehaviour
{
    public GameObject pelota;

    public float speed;

    void Update()
    {
        float vertical = 0;
        if (transform.position.y > pelota.transform.position.y )
        {
            vertical = -1f;
        }
        if (transform.position.y < pelota.transform.position.y)
        {
            vertical = 1f;
        }
        transform.position += new Vector3(0, vertical, 0) * Time.deltaTime * speed;
    }
}
