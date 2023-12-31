using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class WatermelonBehavior : MonoBehaviour
{
    public Rigidbody2D melonRigidbody2D;
    private float deadZone = -5f;
    // Start is called before the first frame update
    void Start()
    {
        melonRigidbody2D.velocity = new Vector2(Random.Range(-1f, 1f), melonRigidbody2D.velocity.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Melon Caught");
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
