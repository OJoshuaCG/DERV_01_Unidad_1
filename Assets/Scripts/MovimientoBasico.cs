using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoBasico : MonoBehaviour
{
    public float desplazamiento = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)) {
            Debug.Log("Arriba");
            transform.Translate(Vector3.forward * desplazamiento * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.S)) {
            Debug.Log("Abajo");
            transform.Translate(Vector3.back * desplazamiento * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.A)) {
            Debug.Log("Izquierda");
            transform.Translate(Vector3.left * desplazamiento * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.D)) {
            Debug.Log("Derecha");
            transform.Translate(Vector3.right * desplazamiento * Time.deltaTime);
        }
    }
}
