using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loaders : MonoBehaviour
{
    public int sceneID = 2;
    private void OnCollisionEnter(Collision collision){
        string etiqueta = collision.gameObject.tag;

        if(etiqueta.Equals("Player")){
            SceneManager.LoadScene(sceneID);
        }
    }

    void OnTriggerEnter(Collider collision) {
        string etiqueta = collision.gameObject.tag;

        if(etiqueta.Equals("Player")){
            SceneManager.LoadScene(sceneID);
        }
    }
}
