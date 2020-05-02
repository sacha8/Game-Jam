using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    [Header("PlayerLife")]
    public float life;
    public float LifeMax;
    public GameObject Handle;

    private RectTransform lifebarre;
    private float timer = 0.0f;
    private float WaitTime = 5.0f;
    private bool IsTrigger = false;
    [Header("restarte(gameOver)")]
    public string Restarte;

    void Start()
    {
        lifebarre = Handle.GetComponent<RectTransform>();
        lifebarre.localScale = new Vector3(life / LifeMax, 1, 1);
    }

    void Update()
    {
        if(life <= 0)
        {
            SceneManager.LoadScene(Restarte);
        }



        timer += Time.deltaTime;
        if (timer > WaitTime)
        {
            if (IsTrigger)
            {
                life -= 25.0f;
                lifebarre.localScale = new Vector3(life / LifeMax, 1, 1);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "ennemi")
        {
            IsTrigger = true;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "ennemi")
        {
            IsTrigger = false;
        }
    }

}
