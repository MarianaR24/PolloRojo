using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public Transform player; // Referencia al jugador
    public float smoothSpeed = 0.125f; // Velocidad de suavizado
    public Vector3 offset = new Vector3(0f, 1.5f, -10f); // Ajusta la posición de la cámara (Z fija)

    void LateUpdate()
    {
        if (player == null)
        {
            Debug.LogWarning("No se ha asignado el jugador a la cámara");
            return;
        }

        Vector3 desiredPosition = new Vector3(player.position.x + offset.x, player.position.y + offset.y, -10f);
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }
}
