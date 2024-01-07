using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoviminetoJugador : MonoBehaviour
{

    public float speed;
    public string inputVertical;
    void Update()
    {

        float vertical = Input.GetAxis(inputVertical);

        transform.position += new Vector3(0, vertical, 0) * Time.deltaTime * speed;
    }
}
