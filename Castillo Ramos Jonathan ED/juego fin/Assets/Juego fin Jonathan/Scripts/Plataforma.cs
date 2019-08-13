/* El código tiene como función asignarle un movimiento definido de las plataformas, tomando como puntos 
 de referencia objetos vacíos */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour
//Se le asignará a la plataforma una velocidad y los puntos a recorrer como trayectoria
{
    public float velocidad;
    public Transform sierra;
    public Transform[] puntos;
    public Transform target;
    public int indiceTarget;

    // Start is called before the first frame update
    void Start()
    {
        //Se convierte en el elemento inicial el indice 1
        target = puntos[1];
        //.position lee la posición que tendrá el objeto a moverse
        sierra.position = target.position;
        velocidad = velocidad * Time.deltaTime;
        indiceTarget = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = target.position - sierra.position;
        //distance va a medir la distancia emntre el objeto a mover y el objetivo 
        float distance = Vector3.Distance(sierra.position, target.position);
        //Se va a trasladar tomando en cuenta la normalizacion de la velocidad midiendo su espacio en el mundo
        sierra.Translate(dir.normalized * velocidad, Space.World);

        //si la distancia es menor o igual a 0.5 se le suma uno a indice, que es el que indica hacia que punto se va a mover
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
}
