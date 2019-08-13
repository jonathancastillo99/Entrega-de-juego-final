/* El código tiene como función asignarle un movimiento definido a un sprite con forma de sierra
 El motivo es que ésta siga una trayectoria definida por una distiancia y una velocidad
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SierraMov : MonoBehaviour
{

    //En este punto, se almacena el punto de partida de la sierra, se declara su velocidad y cuánto va a moverse
    private Vector3 originalTransform;
    public float velocidad;
    public float distancia;

    // Start is called before the first frame update

    // Se debe tomar en cuenta la posición inicial y la posicion en la que la sierra va a moverse
    void Start()
    {
        originalTransform = this.transform.position;
    }

    // Update is called once per frame
    //Es necesario que la sierra gire, por lo que se multiplica el tiempo y la velocidad con una distancia de cero, por lo que la sierra rotará
    void Update()
    {
        transform.position = originalTransform + new Vector3(Mathf.Sin(Time.time *velocidad) * distancia, 0);

    }
}
