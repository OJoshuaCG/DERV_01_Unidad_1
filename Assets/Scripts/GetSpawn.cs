using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GetSpawn : MonoBehaviour
{   
    public TextMeshProUGUI txt_puntaje;

    private void OnTriggerEnter(Collider other) {
        if(!other.tag.Equals("Player")){
            // Obtenemos el nombre del material de éste objeto
            Renderer rend = this.GetComponent<Renderer>();
            string material = rend.material.ToString();
            
            // Obtenemos el nombre del material del objeto que hizo colision
            rend = other.GetComponent<Renderer>();
            string otherMaterial = rend.material.ToString();
            
            // Si tienen el mismo material (color) se destruye el objeto colisionado
            if(otherMaterial.Equals(material)){
                Destroy(other);
                UpdatePoints();
            }
        }
    }

    
    
    private void UpdatePoints(){
        int puntaje = int.Parse(txt_puntaje.text);
        puntaje++;
        txt_puntaje.text = puntaje.ToString();
    }

}
