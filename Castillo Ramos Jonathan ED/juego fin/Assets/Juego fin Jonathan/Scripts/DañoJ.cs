/*
 Jonathan Castillo
 Materia: Estructura de datos
 Grupo: DAA06A
 Profesor: Josue Isarel Rivas Días
 Descripción breve de funcionamiento de codigo: El código tiene como función asignarle un valor numérico al daño que recibirá un 
 jugador tras ser tocado por un enemigo

 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DañoJ : MonoBehaviour
//Se declara la variable de la vida del jugador y se le asigna al objeto que lo representa
{
    public VidaJ vidajugador;

    void Start()
    {
        vidajugador = GameObject.Find("Player").GetComponent<VidaJ>();
    }

    private void OnCollisionEnter(Collision collision)
    {


        if (collision.gameObject.tag == "Player")
        {
            vidajugador.vida -= 10;
        }

    }


}
