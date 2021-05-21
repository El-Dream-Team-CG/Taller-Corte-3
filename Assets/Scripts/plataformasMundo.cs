using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataformasMundo : MonoBehaviour
{
    // public float speed2= 1.0f;
    public Vector3 dir;
    public float speed;
    public float PosicionInferior;
    public float PosicionSuperior;
    // Start is called before the first frame update
    void Start()
    {
        dir = Vector3.up;
    }

    // Update is called once per frame
    void Update()
    {
       transform.Translate(dir * speed * Time.deltaTime, Space.World);

        if (transform.position.y >= PosicionSuperior)
        {
            dir = Vector3.down;
        }

        if (transform.position.y <= PosicionInferior)
        {
            dir = Vector3.up;

        }
    }
}

