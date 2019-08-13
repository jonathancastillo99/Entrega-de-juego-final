/*
El código tiene como función asignarle un valor numérico ligado a un objeto y que represente su "vida"
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class VidaJ : MonoBehaviour
//Primero se declara una variable que represente la vida
//La vida se vincula con una caja de texto para poder observar sus cambios
{
    public float vida;
    public Text vidaText;

    //Se vincula la vida al texto que aparecerá en pantalla
    private void Start()
    {
        vidaText.text = vida.ToString();
    }
     
    //Se declara que la interfaz de texto se actuaizará junto a la variable de vida
    private void Update()
    {
        vidaText.text = vida.ToString();

        //Se declara que si la vida del jugador llega a cero o menos, éste será destruido

        if (vida <= 0)
        {
            Destroy(GameObject.Find("Player"));
        }
        //Se declara que si la vida del jugador llega a cero o menos, entonces aparecerá el texto ligado al script de Game Over
        if (vida <= 0)
        {
            GameOver.show();
        }
    }

    //En este punto se declara que si el jugador colisiona con los objetos con las tag de ítems de curación, recuperará 15 unidades de vida
    private void OnCollisionEnter(Collision collision)
    {


        if (collision.gameObject.tag == "Vendas")
        {
            vida += 15;
        }

        if (collision.gameObject.tag == "Vendas01")
        {
            vida += 15;
        }
    }

}
