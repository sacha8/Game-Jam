using UnityEngine;
using UnityEngine.SceneManagement;

public class JouerQuitter : MonoBehaviour
{
    public string Jouer;

    public void jouer()
    {
        SceneManager.LoadScene(Jouer);
    }

    public void Quitter()
    {
        Application.Quit();
    }
}
