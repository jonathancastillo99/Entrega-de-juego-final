/*El código tiene como función asignarle un movimiento a un objeto por medio de puntos 
 para que este patrulle pero, al cercársele un enemigo pueda perseguirlo (cambio de estados)
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Se ponen los nombres del identificador de acción a utilizar

//Se declara la variable que representará al enemigo y a sus distintos modos de acción
public enum EnemigoIA
{
    Patrulla, Perseguir, Atacar
}

public class MovEnemigo: MonoBehaviour
//Se le asignará al enemigo una velocidad, movimiento y objetivo a perseguir, además se asignan los puntos para que tenga trayectoria de patrullaje
{
    public float velocidad;
    public Transform sierra;
    public Transform[] puntos;
    public Transform target;
    public int indiceTarget;
    //esta almacena estado o ubicacion del jugador en el mapa
    public Transform player;
    public EnemigoIA EstadoActual = new EnemigoIA();


    // Start is called before the first frame update
    void Start()
    {
        // Se declara que el enemigo estará en un estado inicial (patrulla)
        EstadoActual = EnemigoIA.Patrulla;
        //Se convierte en el elemento inicial el indice 1
        target = puntos[1];
        //.position lee la posición
        sierra.position = target.position;
        velocidad = velocidad * Time.deltaTime;
        indiceTarget = 0;
    }

    // Update is called once per frame
    void Update()

        //Llegados a este punto, se delcara que el objeto (en este caso enemigo) tendrá la capacidad de moverse y detectar la distancia al jugador
    {
        Vector3 dir = target.position - sierra.position;
        //distance va a medir la distancia emntre el objeto a mover y el objetivo 
        float distance = Vector3.Distance(sierra.position, target.position);

        float distancePlayer = Vector3.Distance(sierra.position, player.position);

        //Se va a trasladar tomando en cuenta la normalizacion de la velocidad midiendo su espacio en el mundo
        sierra.Translate(dir.normalized * velocidad, Space.World);

        //si la distancia es menor o igual a 0.5 se le suma uno a indice, que es el que indica hacia que punto se va a mover

        if (EstadoActual == EnemigoIA.Patrulla)
        {
            target = puntos[indiceTarget];

            if (distance <= 0.5f)
            {
                //.Length es para que el sistema lea la extensión total del array lee cada nunero o valor dentro del array desde 0 hasta 4
                //El -1 se obliga a que se lea solo hasta el último punto, no se sobrecarga el array
                if (indiceTarget >= puntos.Length - 1)
                {
                    indiceTarget = 0;
                    target = puntos[indiceTarget];
                }

                indiceTarget++;
                target = puntos[indiceTarget];
            }
        }

        //Aquí se declara la distancia que debe existir entre el jugador y el enemigo para que éste cambie de estado y lo persiga

        if (distancePlayer <= 5)
        {
            EstadoActual = EnemigoIA.Perseguir;
        }

        //Aquí se declara que si el jugador excede cierta distancia, el enemigo dejará de atacarlo y volverá a patrullar

        else if (distancePlayer > 5)
        {
            EstadoActual = EnemigoIA.Patrulla;
        }

        if (EstadoActual == EnemigoIA.Perseguir)
        {
            target = player;
        }


    }
}
