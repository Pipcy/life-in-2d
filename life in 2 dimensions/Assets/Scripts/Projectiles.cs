//Projectile.cs
using UnityEngine;

public class Projectiles : MonoBehaviour
{
    [SerializeField] private float speed;
    private float direction;
    private bool hit;
    private float lifetime;

    //private Animator anim;
    private BoxCollider2D boxCollider;

    private void Awake() 
    {
        //anim = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();
        Deactivate();
    }

    private void Update() 
    {
        if (hit) return;
        float movementSpeed = speed * Time.deltaTime * Mathf.Sign(-direction);

        transform.Translate(movementSpeed, 0, 0);

        lifetime += Time.deltaTime;
        if (lifetime > 5) gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        hit = true;
        boxCollider.enabled = false;
        Deactivate();
        //anim.SetTrigger("explode");
        
    }

    public void SetDirection(float _direction)
    {
        lifetime = 0;
        direction = _direction;
        gameObject.SetActive(true);
        hit = false;
        boxCollider.enabled = true;

        //make sure bellet facing the right way
        float localScaleX = transform.localScale.x;
        if(Mathf.Sign(localScaleX) == _direction)
            localScaleX = -localScaleX;

        transform.localScale = new Vector3(localScaleX, transform.localScale.y, transform.localScale.z);


    }

    private void Deactivate()
    {
        gameObject.SetActive(false);
    }
}