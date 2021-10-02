using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControllerPlayScene : MonoBehaviour
{
    public int scene;

    public void IniciarJuego(){
        SceneManager.LoadScene(scene);
    }
}
