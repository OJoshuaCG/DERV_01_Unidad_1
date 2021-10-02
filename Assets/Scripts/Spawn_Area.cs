using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Spawn_Area : MonoBehaviour
{   
    //public TextMeshProUGUI txt_puntaje;
    public TextMeshProUGUI txt_tiempo;
    public GameObject objLanzar;
    public Material[] materials;

    System.Random rnd = new System.Random();
    
    float x, y = 2, z;
    float inf = -5.0f, sup = 5.0f;
    int i = 0, tiempo = 60, puntaje = 0;

    void Start()
    {
        StartCoroutine("corrutinaSpawn");
        StartCoroutine("corrutinaTiempo");
    }


    IEnumerator corrutinaSpawn(){
        while(true){
            x = GetRndFloat();
            z = GetRndFloat();            
            
            GameObject obj = Instantiate(objLanzar,         // Se establece el objeto
                            new Vector3(x, y, z),           // La posicion (x & z random)
                            new Quaternion(0f, 0f, 0f, 1))  // La rotacion
                            as GameObject;                  // Se transforma en un GameObject
            obj.name = "object_" + i;
            
            // Se establece el Material (color)
            int aux = rnd.Next(0, 4);
            Renderer rend = obj.GetComponent<Renderer>();
            rend.material = materials[aux];

            i++;
            yield return new WaitForSeconds(2.0f);
        }
    }

    IEnumerator corrutinaTiempo(){
        while(tiempo > 0){
            tiempo--;
            txt_tiempo.text = tiempo.ToString(); 
            
            yield return new WaitForSeconds(1.0f);        
        }
        StopCoroutine("corrutinaSpawn");
        StopCoroutine("corrutinaTiempo");        
    }

    /*
    private void OnTriggerEnter(Collider other) {
        if(other.tag.Equals("Player")){
            x = GetRndFloat();
            z = GetRndFloat();            
            
            GameObject obj = Instantiate(objLanzar,         // Se establece el objeto
                            new Vector3(x, y, z),           // La posicion (x & z random)
                            new Quaternion(0f, 0f, 0f, 1))  // La rotacion
                            as GameObject;                  // Se transforma en un GameObject
            obj.name = "object_" + i;

            // Elegimos el material y definimos el tag
            int aux = rnd.Next(0, 4);
            
            // Se establece el Tag
            //obj.tag = materials[aux].ToString();
            //Debug.Log(materials[aux].ToString());

            //Debug.Log("El tag es: " + obj.tag.ToString());

            // Se establece el Material (color)
            Renderer rend = obj.GetComponent<Renderer>();
            rend.material = materials[aux];

            i++;
        }
    }
    */


    private float GetRndFloat(){
        double aux = rnd.NextDouble()*(inf-(sup))+(sup);
        return((float)aux);
    }

    /*
    public void UpdatePoints(){
        puntaje++;
        txt_puntaje.text = puntaje.ToString();
    }
    */
    
}
