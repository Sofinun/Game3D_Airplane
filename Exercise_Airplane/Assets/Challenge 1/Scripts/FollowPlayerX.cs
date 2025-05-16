using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset;


    void Start()
    {
        //Diferencia entre la posición de la cámara y la del jugador
		offset = transform.position - plane.transform.position;
    }


    void LateUpdate()
    {
        // Actualiza la posición de la cámara para que siga al jugador
        // La cámara se posiciona en la misma posición que el jugador + el offset
        // La cámara sigue al jugador en el eje Y y Z, pero no en el eje X    
        transform.position = plane.transform.position + offset;
    }
}
