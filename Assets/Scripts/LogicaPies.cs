using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaPies : MonoBehaviour
{
    public LogicaPJ2 logicaPJ2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        logicaPJ2.puedoSaltar = true;
    }
    private void OnTriggerExit(Collider other)
    {
        logicaPJ2.puedoSaltar = false;

    }
}
