using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 10f;
    public ParticleSystem ps;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ps.Emit(1);
        ps.Play();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal1 = 0;
        float vertical1 = 0;
                        
        horizontal1 = Input.GetAxis("Horizontal");
        vertical1 = Input.GetAxis("Vertical");

        Vector2 position = rb.position; 

        position.x = position.x + 0.1f * horizontal1 * Time.deltaTime * speed;
        position.y = position.y + 0.1f * vertical1 * Time.deltaTime * speed;
       

        rb.MovePosition(position);
    }
}
