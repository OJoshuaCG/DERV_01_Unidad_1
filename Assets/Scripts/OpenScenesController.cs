using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenScenesController : MonoBehaviour
{
    public int sceneID;
    void Start()
    {   
        
    }

    public void IniciarJuego(){
        SceneManager.LoadScene(sceneID);
    }
}
