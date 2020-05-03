using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Fin : MonoBehaviour
{
    public string fin;
    public string Menu;

    void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(fin);
    }

    public void Fini()
    {
        SceneManager.LoadScene(Menu);
    }
}
