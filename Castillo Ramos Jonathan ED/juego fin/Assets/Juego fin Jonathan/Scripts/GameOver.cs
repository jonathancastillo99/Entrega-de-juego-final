using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    // Se declara que se usará un objeto de juego que fungirá como el "Game Over" y se delcara que habrá un estado estático
    public GameObject TextoGO;
    public static GameObject GameOverStatic;
    // Start is called before the first frame update

        // Se declarará que el objeto "Game Over" no será visible hasta que algo loa ctive
        
    void Start()
    {

        GameOver.GameOverStatic = TextoGO;
        GameOver.GameOverStatic.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    } 

    //En esta parte, se delcara la posibilidad de que el "Game Over sea activado
    public static void show()
    {
        GameOver.GameOverStatic.gameObject.SetActive (true);
    }
}

