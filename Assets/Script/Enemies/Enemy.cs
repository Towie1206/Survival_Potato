using UnityEngine;

public class Enemy : MonoBehaviour
{
    protected int health;
    protected int maxHealth;
    protected int speed;
    protected int damage;
    protected int experiencePoints;

    protected AudioSource hitSound;
    protected AudioSource destroySound;
    protected AudioSource attackSound;

    public virtual void Awake()
    {
      
    }
    public virtual void OnEnable()
    {
        health = maxHealth;
    }
    public virtual void Start()
    {
        
    }

    public virtual void Update()
    {
        
    }

    public virtual void CollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerController player = collision.gameObject.GetComponent<PlayerController>();
            if(player) player.TakeDamage(damage);
        }
    }
}
