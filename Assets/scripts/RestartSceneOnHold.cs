using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartSceneOnHold : MonoBehaviour
{
    public float holdTimeRequired = 15f; // Segundos necesarios
    private float holdTimer = 0f;

    void Update()
    {
        // Verifica si el botón Menu del mando izquierdo está presionado
        if (OVRInput.Get(OVRInput.Button.Start, OVRInput.Controller.LTouch))
        {
            holdTimer += Time.deltaTime;

            if (holdTimer >= holdTimeRequired)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
        else
        {
            // Si se suelta antes, se reinicia el contador
            holdTimer = 0f;
        }
    }
}

