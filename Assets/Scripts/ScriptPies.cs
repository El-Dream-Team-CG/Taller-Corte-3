using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPies : MonoBehaviour
{
    public animacionPersonaje1 animacionpersonaje;

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
        animacionpersonaje.puedoSaltar = true;
    }
    private void OnTriggerExit(Collider other)
    {
        animacionpersonaje.puedoSaltar = false;

    }

}
