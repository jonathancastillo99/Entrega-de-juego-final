/* Este script tiene como función hacer que la cámara enfoque al jugador a lo largo de la partida  */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraF : MonoBehaviour

/* Se declara una variable que fungirá como el objetivo de la cámara */
{
    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    // Update is called once per frame

    /* En esta parte, se especifica que la cámara irá siguiendo al jugador, es 
     decir que se actualizará con respecto a las acciones del jugador */

    void LateUpdate()
    {

        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        //transform.LookAt(target);
    }
}
