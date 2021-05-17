using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animacionPersonaje1 : MonoBehaviour
{
    public Rigidbody rb;
    public float velocidadM;
    public float velocidadR;
    private Animator animacion;
    public float x, y;

    //salto
    public float fuerzaDeSalto = 8f;
    public bool puedoSaltar;

    void Start()
    {
        puedoSaltar = false;
        velocidadM = 5f;
        velocidadR = 200f;
        animacion = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        transform.Rotate(0, x * Time.deltaTime * velocidadR, 0);
        transform.Translate(0, 0, y * Time.deltaTime * velocidadM);
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        animacion.SetFloat("VelocidadX", x);
        animacion.SetFloat("VelocidadY", y);

        if (
            
            )
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                animacion.SetBool("Salte", true);
                rb.AddForce(new Vector3(0, fuerzaDeSalto, 0), ForceMode.Impulse);
            }
            animacion.SetBool("TocoSuelo", true);
        }
        else
        {
            EstoyCayendo();
        }
        if ()
    }

    public void EstoyCayendo()
    {
        animacion.SetBool("TocoSuelo", false);
        animacion.SetBool("Salte", false);
    }

    //void OnCollisionStay(Collision col)
    //{
    //    collidedWith = col.gameObject;
    //    if(collidedWith.tag == "Agua")
    //    {

    //    }
    //}
    void OnCollisionEnter(Collision collision)
    {
        //Output the Collider's GameObject's name
        Debug.Log(collision.collider.tag);
    }   

    void OnCollisionStay(Collision collision)
    {
        //Check to see if the Collider's name is "Chest"
        if (collision.collider.tag == "Agua")
        {
            animacion.SetBool("Nade", true);
        }
    }
}