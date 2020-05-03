using UnityEngine;
using UnityEngine.SceneManagement;

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
    public int AttaqueDommage = 10;
    [Header("Life")]
    public float life;
    public float lifeMax;
    public GameObject Handle;
    private RectTransform lifeBarre;
    private float timer;
    private float waiTtime;
    private bool IsTrigger = false;
    public string restart;



    private void Start()
    {
        lifeBarre = Handle.GetComponent<RectTransform>();
        lifeBarre.localScale = new Vector3(life / lifeMax, 1, 1);

        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(life <= 0)
        {
            SceneManager.LoadScene(restart);
        }


        timer += Time.deltaTime;
        if(timer > waiTtime)
        {
            timer = 0.0f;
            if (IsTrigger)
            {
                life -= 1;
                lifeBarre.localScale = new Vector3(life / lifeMax, 1, 1);
            }
        }


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

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "ennemi")
        {
            IsTrigger = true;
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if(col.gameObject.tag == "ennemi")
        {
            IsTrigger = false;
        }
    }
}
