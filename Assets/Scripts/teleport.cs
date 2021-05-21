using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    public Transform teleportTarget;
    public GameObject LogicaPJ2;

    void OnTriggerEnter(Collider other)
    {
        LogicaPJ2.transform.position = teleportTarget.transform.position;
    }
}
