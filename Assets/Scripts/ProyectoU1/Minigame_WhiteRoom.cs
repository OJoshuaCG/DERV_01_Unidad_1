using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minigame_WhiteRoom : MonoBehaviour{    
    //public GameObject ObjDestino;
    public float speed = 0.5f;
    public float alturaDestino = 26.5f;


    public GameObject objLanzar;
    System.Random rnd = new System.Random();

    float x, y, z;
    public static float area_Size = 40;
    //float inf = -5.0f, sup = 5.0f;
    static float inf = area_Size/2*-1;
    static float sup = area_Size/2;
    int i = 0;
    bool isTrigger = true;


    void Start() {
                       
    }

    
    void Update() {        
        if(!isTrigger){
            Vector3 origen = transform.position;
            Vector3 destino = new Vector3(origen.x, alturaDestino, origen.z);

            //destino.y -= 0.5f;       

            transform.position = Vector3. MoveTowards(origen, destino, speed * Time.deltaTime);
        }
    }


    private void OnTriggerEnter(Collider other) {
        string tag = other.gameObject.tag;
        if(isTrigger && tag == "Player"){
            StartCoroutine("corrutinaSpawn");
            isTrigger = false;
        }
    }

    
    IEnumerator corrutinaSpawn(){
        while(i < 140){
            x = GetRndFloat();
            z = GetRndFloat();            
            
            GameObject obj = Instantiate(objLanzar,         // Se establece el objeto
                            new Vector3(transform.position.x+x, alturaDestino + 5, transform.position.z+z),           // La posicion (x & z random)
                            new Quaternion(0f, 0f, 0f, 1))  // La rotacion
                            as GameObject;                  // Se transforma en un GameObject
            obj.name = "object_" + i;
            //bj.tag = "spawn";
            
            Destroy(obj, 7);

            i++;
            yield return new WaitForSeconds(0.25f);
        }        
    }

    private float GetRndFloat(){
        double aux = rnd.NextDouble()*(inf-(sup))+(sup);
        return((float)aux);
    }

    void OnDrawGizmos() {
        Gizmos.color = Color.green;
        
        
        Gizmos.DrawCube(transform.position, new Vector3(area_Size,0.1f,area_Size));
    
    }
}
        //transform.position = Vector3.Lerp(origen, destino, speed * Time.deltaTime);

        /*
        Vector3 currentVelocity = new Vector3(0f, 0f, 0f);
        transform.position = Vector3.SmoothDamp(origen, destino, ref currentVelocity, speed * Time.deltaTime);
        */

        //float distancia = Vector3.Distance(origen, destino);
