using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ColisionesTAG : MonoBehaviour
{
    /*
     * REALIZAR UNA ADAPTACIÓN DEL TEMA VISTO EN CLASE EL DÍA 8 DE SEPT
     * PARA SU PROYECTO. 
     * 
     *          ENTREGA - LUNES 13 DE SEPT
     *                      >  CAPTURAS DE PANTALLA EN TEAMS
     *                      >  1 VÍDEO DE APROX 8MINS 
     *                        (2MIN MINIMO POR PERSONA EXPLICANDO EL CÓDIGO
     *                              Y EL FUNCIONAMIENTO DEL PROYECTO)
     *                              SUBIRLO A ALGUNA PLATAFORMA EN LA NUBE, COMO DROPBOX / TEAMS
     *                              Y COMPARTIR EL ENLACE EN TEAMS
     */ 


    public TextMeshProUGUI txt_puntaje;
    public TextMeshProUGUI txt_vida;

    int puntaje;
    int vida;

    // Start is called before the first frame update
    void Start()
    {
        puntaje = 0;
        vida = 100;

        StartCoroutine("corrutinaVida");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        //vida--;
        //txt_vida.text = vida.ToString();
    }


    private void OnCollisionEnter(Collision collision)
    {
        string etiqueta = collision.gameObject.tag;
        string nombre;

        Debug.Log("Colisión con: " + etiqueta);

        if (etiqueta.Equals("Enemigo"))
        {
            nombre = collision.gameObject.name;

            GameObject gameObj;
            gameObj = GameObject.Find(nombre);

            Destroy(gameObj);

            puntaje++;
            txt_puntaje.text = puntaje.ToString();
        }
        else if(etiqueta.Equals("PowerUP"))
        {
            vida++;
            txt_vida.text = vida.ToString();
        }


    }

    private void OnCollisionStay(Collision collision)
    {
        string etiqueta = collision.gameObject.tag;
        

        Debug.Log("Colisión con: " + etiqueta);

        if (etiqueta.Equals("PowerUP"))
        {
            vida++;
            txt_vida.text = vida.ToString();
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        
    }

    //Corrutina
    IEnumerator corrutinaVida() {
        while (true) {

             vida-=5;
             txt_vida.text = vida.ToString();


            yield return new WaitForSeconds(1.0f);
        }
    }

}
