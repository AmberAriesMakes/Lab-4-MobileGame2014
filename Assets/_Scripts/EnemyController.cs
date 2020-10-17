using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float Hspeed;
    public float HBoundary;
    public float direction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Move()
    {
        transform.position += new Vector3(Hspeed * direction * Time.deltaTime, 0.0f, 0.0f);
    }

       private void _CheckBounds()
    {
        if(transform.position.x >= HBoundary)
        {
            direction = -1.0f;
        }
        if (transform.position.x <= -HBoundary)
        {
            direction = 1.0f;
        }
    }
}
