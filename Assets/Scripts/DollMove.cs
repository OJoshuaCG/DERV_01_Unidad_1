using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DollMove : MonoBehaviour
{
    // Coordenadas Originales: (73.317, 1.223, 49.02)
    //Segundo y penultimo valor son en medio
    float [] x =  {72.022f, 49.11f, 50.28f};
    float y = 0.34f;
    float [] z = {66.422f, 57.32f, 78f};
    int numberMove = 0;



    private void OnCollisionEnter(Collision collision) 
    {
        string etiqueta = collision.gameObject.tag;

        if(numberMove < x.Length && etiqueta.Equals("Player"))
        {   // Vamos cambiando de posicion a la muñeca
            transform.position = new Vector3(x[numberMove], y, z[numberMove]);
            numberMove++;
            if(numberMove == x.Length)
            {
                unblockEntry();
            }
        }
    }
    
    private void unblockEntry()
    {
        GameObject gameObj;
        gameObj = GameObject.Find("BlockEntry");
        Destroy(gameObj);
    }

    
}
