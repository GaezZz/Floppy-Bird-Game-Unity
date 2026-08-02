using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; //tengo que añadirlo yo para usar el texto y cosas de ui

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText; //al igual q con rigidbody, creo un sitio para pasarle el texto que debe cambiar
    public GameObject gameOver;

        void Start()
    {
        Time.timeScale = 1f;
    }


    [ContextMenu("Sumar puntuacion")] //si pongo esto, en unity puedo simular esta parte del codigo (como si se hubiera activado por X causa) para ver si funciona
    public void addScore(int nScore) //hago yo una funcion que añada la puntuacion, como es algo global la pongo en public
    {
        playerScore += nScore; //como esto solo es la ui del juego, añade un punto y lo pone en la pantalla
        scoreText.text = playerScore.ToString(); //debo pasarlo a string, lo pilla como numero y no lo puede usar para el texto
    }

    public void newGame()
    {
        Time.timeScale = 1f;    //paro completamente el juego
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    public void finGame()
    {
        Time.timeScale = 0f;    //paro completamente el juego
        gameOver.SetActive(true); //activo la casilla con el boton de reinicio, esto llega desde el trigger de las pipes cuando colisionan
    }


}
