/*El código tiene como función asignarle un movimiento definido al jugador.
El jugador se moverá lateralmente con las teclas A y D y saltará con W

 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPlay : MonoBehaviour
//Se declara una variable que será la velocidad a la que el jugador va a moverse, además se declara una variable que simulará la fuerza del salto del jugador
{
    public float velocidad;
    public float FuerzaSalto;
    //Aquí se declara la velocidad a la que el jugador girará "la vista" al cambiar de dirección
    public float turnSpeed = 50f;

    private bool Salto;
    private Rigidbody Jugador;
   
    // Start is called before the first frame update
    void Start()
    {
        Jugador = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    /*
         A cada tecla en custión se le asignará una transformación; ésta reemplazará el valor de un eje por la variable de velocidad,
         alternándose entre valores positivos y negativos para desplazar al cubo en el espacio

    */
    {
        // Aquí se declara el salto que realizará el jugador, tomando en cuenta sus ejes
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, velocidad, 0) * Time.deltaTime);
        }

        // Aquí se declara hacia dónde se moverá el jugador tomando en cuenta los ejes, tomando en cuenta la rotación del jugador y sus ejes

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(velocidad, 0, 0) * Time.deltaTime);
            transform.localScale= new Vector3(0.65748f, 0.65748f, 0.65748f);

        }


        if (Input.GetKey(KeyCode.A))
        {
           transform.Translate(new Vector3(-velocidad, 0, 0) * Time.deltaTime);
           transform.localScale = new Vector3(-0.65748f, 0.65748f, 0.65748f);
        }
    }
}
