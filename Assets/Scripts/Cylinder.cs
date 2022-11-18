using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : BaseShape
{
    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // Update is called once per frame
    // void Update()
    // {

    // }

    protected override void MovingShape()
    {
        Speed = 500.0f;
        base.MovingShape();
        messageText += $"{nameof(MovingShape)} of {this.name} class\r\n";
        ChangeColor();
    }
    private void ChangeColor( ){
        Color next = new Color( GenerateColorValue() , GenerateColorValue() , GenerateColorValue(),GenerateColorValue() );
        GetComponent<Renderer>().material.color = next;
        // Debug.Log( next);
    }

    private float GenerateColorValue(){
        return Random.Range( 0.5f, 1.0f);
    }
}
