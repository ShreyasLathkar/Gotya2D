using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public int startPoint;
    public Transform[] Points;
    int i;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = Points[startPoint].position;

    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, Points[i].position) < 0.5)
        {
            i++;
            if (i == Points.Length)
            {
                i = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, Points[i].position, speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            if (transform.position.y < collision.transform.position.y - 0.2f)
            {
                collision.transform.SetParent(transform);
            }
        }
    }
   private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            collision.transform.SetParent(null);
        }
    }
}
