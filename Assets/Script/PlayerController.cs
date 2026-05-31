using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    public static PlayerController Instance;

    private Rigidbody2D rb;
    private Vector2 movement;

    [SerializeField] float speed = 1.2f;

    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float inputX = Input.GetAxisRaw("Horizontal");
        float inputY = Input.GetAxisRaw("Vertical");
        movement = new Vector2(inputX, inputY).normalized;
    }
    void FixedUpdate()
    {
       rb.linearVelocity = new Vector2(movement.x * speed, movement.y * speed);
    }
    public void TakeDamage(int damage)
    {

    }    
}
