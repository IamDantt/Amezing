using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//estados del juego 
public enum GameState
{
    menu,
    inTheGame,
    gameOver
}

public class GameManager : MonoBehaviour
{
    //permite compartir estado del juego entre componentes
    public static GameManager sharedInstance;

    //Se inicia el estado del juego en el menu principal
    public GameState currentGameState = GameState.menu;

    //se ejecuta a iniciar el programa
    void Awake()
    {
        //selecciona la instancia creada
        sharedInstance = this;    
    }

    void Start()
    {
        //Arranca el manager en el estado menu
        currentGameState = GameState.menu;
    }

    void Update()
    {
        //Si presionamos la tecla p cambiamos estado de menu a estado de juego
        if (Input.GetButtonDown ("p"))
        {
            //Inicia el juego
            currentGameState = GameState.inTheGame;
        }
        if (Input.GetButtonDown("Escape"))
        {
            //Pausa el juego
            currentGameState = GameState.menu;
        }
    }

    //Se llama para iniciar la partida
    public void StartGame()
    {
        //Inicia el estado del juego a in game
        ChangeGameState(GameState.inTheGame);
    }

    //Se llama cuando el jugador pierde
    public void GameOver()
    {
        ChangeGameState(GameState.gameOver);
    }

    //se llama cuando se quiera regresar al menu
    public void BackToMainMenu()
    {
        ChangeGameState(GameState.menu);
    }

    //metodo encargado de cambiar los estados
    void ChangeGameState(GameState newGameState)
    {
        if (newGameState == GameState.menu)
        {

        }
        else if (newGameState == GameState.inTheGame)
        {

        }
        else if (newGameState == GameState.gameOver)
        {

        }

        currentGameState = newGameState;
    }

}
