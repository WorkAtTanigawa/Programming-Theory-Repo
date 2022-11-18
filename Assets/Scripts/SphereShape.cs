using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereShape : BaseShape
{
    private float moveCount ;

    private float moveRadius ;
    // Start is called before the first frame update
    // void Start()
    // {
    // }

    // Update is called once per frame
    void Update()
    {
        transform.position = DeltaMove();
    }

    protected override void Initialize()
    {
        // base.Initialize();
        Speed = 10f;
        moveCount = 0;
        moveRadius = 1.5f;
    }
    private Vector3 DeltaMove(){
        Vector3 next = new Vector3( transform.position.x ,transform.position.y ,Mathf.Sin( moveCount )* moveRadius );
        moveCount+= Speed*Time.deltaTime ;
        return next ;
    }

}
