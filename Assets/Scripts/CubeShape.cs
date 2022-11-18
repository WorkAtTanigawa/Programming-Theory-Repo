using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeShape : BaseShape
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
        Speed = 200.0f;
        messageText += $"{nameof(MovingShape)} of {this.name} class\r\n";
        GetComponent<Rigidbody>().AddForce(Vector3.up*10f , ForceMode.Impulse);
    }
}
