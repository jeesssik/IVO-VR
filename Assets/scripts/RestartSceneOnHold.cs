using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class RestartSceneOnHold : MonoBehaviour
{
    public float holdTimeRequired = 15f; // Segundos que hay que mantener presionado
    private float holdTimer = 0f;

    void Update()
    {
        // Verifica si el botón X del mando izquierdo está presionado
        if (OVRInput.Get(OVRInput.RawButton.X, OVRInput.Controller.LTouch))
        {
            holdTimer += Time.deltaTime;

            // Reinicia la escena si se alcanza el tiempo requerido
            if (holdTimer >= holdTimeRequired)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
        else
        {
            // Reinicia el temporizador si se suelta el botón
            holdTimer = 0f;
        }
    }
}

