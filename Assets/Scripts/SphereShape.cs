using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class SphereShape : BaseShape
{
    private float moveCount;

    private float moveRadius;

    // Update is called once per frame
    // POLYMORPHISM
    void Update()
    {
        transform.position = DeltaMove();
    }
    // POLYMORPHISM
    protected override void Initialize()
    {
        // base.Initialize();
        Speed = 10f;
        moveCount = 0;
        moveRadius = 1.5f;
    }
    private Vector3 DeltaMove()
    {
        Vector3 next = new Vector3(transform.position.x, transform.position.y, Mathf.Sin(moveCount) * moveRadius);
        moveCount += Speed * Time.deltaTime;
        return next;
    }

}
