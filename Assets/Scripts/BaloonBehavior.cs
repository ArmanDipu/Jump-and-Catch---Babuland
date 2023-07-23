using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class WatermelonBehavior : MonoBehaviour
{
    public Rigidbody2D balloonRigidbody2D;
    private float deadZone = -5f;
    // Start is called before the first frame update
    void Start()
    {
        balloonRigidbody2D.velocity = new Vector2(Random.Range(-1f, 1f), balloonRigidbody2D.velocity.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Balloon Caught");
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
