using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatermelonBehavior : MonoBehaviour
{
    private float deadZone = -5f;
    // Start is called before the first frame update
    void Start()
    {
        
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
