using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Movement")]
    public float WalkSpeed;
    private Rigidbody2D rb;
    [Header("MoveCameraPlayer")]
    public Camera cam;
    Vector2 MousePos;
    private Animator animator;
    [Header("PunchingPlayer")]
    public Transform PointAttaque;
    public float Attaqueradius;
    public LayerMask EnnemiLayer;
    //public AudioSource AS;

    public int AttaqueDommage = 10;

    private void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Attaque();
        }




        float Horizontal = Input.GetAxisRaw("Horizontal") * WalkSpeed * Time.deltaTime;
        float Vertical = Input.GetAxisRaw("Vertical") * WalkSpeed * Time.deltaTime;

        rb.velocity = new Vector2(Horizontal, Vertical);

        MousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    void FixedUpdate()
    {
        float characterVelocityX = Mathf.Abs(rb.velocity.x);

        animator.SetFloat("WalkSpeed", characterVelocityX);

        Vector2 lookDir = MousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }

    void Attaque()
    {
        //Player attaque

        animator.SetTrigger("Attaque");
        //detecter l'ennemi

        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(PointAttaque.position, Attaqueradius, EnnemiLayer);
        //Ajouter des dommages

        foreach(Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<Ennemi>().TakeDommage(AttaqueDommage);
        }
    }

    void OnDrawGizmosSelected()
    {
        if (PointAttaque == null)
            return;

        Gizmos.DrawWireSphere(PointAttaque.position, Attaqueradius);
    }
}
