using UnityEngine;
using UnityEngine.SceneManagement;

public class menu_game : MonoBehaviour
{
    public void Jogar()

    {
        SceneManager.LoadScene(SceneManager.GetActiveScene() .buildIndex + 1);

    }

    public void Sair()

{

    Debug.Log("Saiu do jogo");
    Application.Quit();

}

}