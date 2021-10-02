using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleColliders : MonoBehaviour
{
    public GameObject linterna;
    private void OnCollisionEnter(Collision collision){
        string etiqueta = collision.gameObject.tag;
        string nombre = collision.gameObject.name;
        GameObject obj = GameObject.Find(nombre);

        if(etiqueta.Equals("ItemInventario")){
            Destroy(obj);
            linterna.SetActive(true);
        }

    }
}
