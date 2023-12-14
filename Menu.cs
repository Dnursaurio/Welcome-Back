using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public void Escenajuego()
    {
        SceneManager.LoadScene("departamento inicial");
    }

    public void Cargarnivel(string Nombrenivel)
    {
        SceneManager.LoadScene(Nombrenivel);
    }

    public void Controles()
    {
        SceneManager.LoadScene("Controles");
    }

    public void menu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void canales()
    {
        SceneManager.LoadScene("dibujitos 80");
    }

    public void MazingerZ()
    {
        SceneManager.LoadScene("Mazinger z episodio 1");
    }

    public void Looney()
    {
        SceneManager.LoadScene("loonet tunes");
    }

    public void menumusica()
    {
        SceneManager.LoadScene("menu musica");
    }

    public void Jump()
    {
        SceneManager.LoadScene("Jump");
    }
    
    public void footloose()
    {
        SceneManager.LoadScene("footloose");
    }

    public void billie()
    {
        SceneManager.LoadScene("Billie Jean");
    }

    public void Salir()
    {
        Application.Quit();
    }
}
