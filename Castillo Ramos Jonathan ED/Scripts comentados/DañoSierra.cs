/* Este script tiene como función lograr que las sierras eleminen al enemigo  */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DañoSierra : MonoBehaviour
/* Se declara una variable que corresponda a la vida del jugador, tomando como referencia la vida de éste (propia de otro script)  */

{
    public VidaJ vidajugador;


    /* Lo primero que se hace es mandar a llamar la variable vida del jugador para que pueda enlazarse a la variable vidajugador  */
    void Start()
    {

        vidajugador = GameObject.Find("Player").GetComponent<VidaJ>();

    }

    /* Se especifica que si el jugador colisiona con cualquier onbjeto 
     que contenga el script (en este caso las sierras), sus puntos de vida serán 
     iguales a cero, por lo que morirá */

    private void OnCollisionEnter(Collision collision)
    {


        if (collision.gameObject.tag == "Player")
        {
            vidajugador.vida = 0;
        }

    }


}

