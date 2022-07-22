using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paterol : MonoBehaviour
{
    public float speed;

    public bool mustPetrol;
    private bool mustTurn;

    public Rigidbody2D rb;
    public Transform groundCheckPos;
    public LayerMask groundLayer;

    public Collider2D bodyCollider;
    // Start is called before the first frame update
    void Start()
    {
        mustPetrol = true;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (mustPetrol)
        {
            Pateroll();
        }

    }
    private void FixedUpdate()
    {
        if (mustPetrol)
        {
            mustTurn = !Physics2D.OverlapCircle(groundCheckPos.position, 0.5f, groundLayer);

        }
    }
    void Pateroll()
    {
        if (mustTurn || bodyCollider.IsTouchingLayers(groundLayer))
        {
            flip();
        }
        rb.velocity = new Vector2(speed * Time.fixedDeltaTime, rb.velocity.y);
    }
    void flip()
    {
        mustPetrol = false;
        transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
        speed *= -1;
        mustPetrol = true;
    }
}
