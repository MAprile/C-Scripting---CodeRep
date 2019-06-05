using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Follow : MonoBehaviour
{
    public Transform player; //variabile per il personaggio o oggetto da far seguire alla telecamera
    public float cameraDistance = 30.0f;

    //Funzione per aggiustare la vista della telecamera
    private void Awake()
    {
        GetComponent<UnityEngine.Camera>().orthographicSize = ((Screen.height / 2) / cameraDistance);
    }

    //Funzione posizionamento camera sul personaggio
    private void FixedUpdate()
    {
        transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
    }
}
