using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public class EscribirLeerArchivo : MonoBehaviour
{
    // Start is called before the first frame update
    string pathFile;
    public Vector3[] posiciones;
    public GameObject[] posPalmas;

    string[] fileline;
    void Start()
    {
        pathFile = "Assets/Resources/coordenadas.txt";
        lectura();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void lectura()
    {
        if (pathFile == null)
            return;




        string[] fileline = File.ReadAllLines(pathFile);
        posiciones = new Vector3[fileline.Length];
        for(int i=0; i< fileline.Length; i++)
        {
            string[] partes = fileline[i].Split("/"[0]);
            float x = float.Parse(partes[0]);
            float y = float.Parse(partes[1]);
            float z = float.Parse(partes[2]);
            //posiciones[i] = new Vector3(x, y, z);
            Vector3 currentPos = new Vector3(x, y, z);
            posPalmas[i].transform.position = currentPos;

            Debug.Log(posPalmas[i].gameObject.name + " " + posPalmas[i].transform.position);
            //Debug.Log("Las coordenadas son: " + posiciones[i].ToString());
        }
    }
}
