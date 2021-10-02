using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoFisico : MonoBehaviour
{
    public float desplazamiento = 10;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update(){}
    
    // Necesario para trabajar con fisicas
    void FixedUpdate() 
    {
        if(Input.GetKey(KeyCode.W)) {
            Debug.Log("Arriba");
            //transform.Translate(Vector3.forward * desplazamiento * Time.deltaTime);
            rb.MovePosition(rb.position + transform.forward  * desplazamiento * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.S)) {
            Debug.Log("Abajo");
            //transform.Translate(Vector3.back * desplazamiento * Time.deltaTime);
            rb.MovePosition(rb.position + transform.forward *-1f * desplazamiento * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.A)) {
            Debug.Log("Izquierda");
            //transform.Translate(Vector3.left * desplazamiento * Time.deltaTime);
            rb.MovePosition(rb.position + transform.right * -1f * desplazamiento * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.D)) {
            Debug.Log("Derecha");
            //transform.Translate(Vector3.right * desplazamiento * Time.deltaTime);
            rb.MovePosition(rb.position + transform.right  * desplazamiento * Time.deltaTime);
        }
    }
}
