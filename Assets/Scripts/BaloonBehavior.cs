using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class WatermelonBehavior : MonoBehaviour
{
    public Rigidbody2D balloonRigidbody2D;
    private Collider2D catchCollider2D;
    public float lifeTime = 5f;
    private float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        catchCollider2D = GameObject.FindGameObjectWithTag("hasCatchCollider2D").GetComponent<Collider2D>();
        balloonRigidbody2D.velocity = new Vector2(Random.Range(-1f, 1f), balloonRigidbody2D.velocity.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == catchCollider2D)
        {
            Debug.Log("Balloon Caught");
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > lifeTime)
        {
            Destroy(gameObject);
        }
        else
        {
            timer += Time.deltaTime;
        }
    }
}
