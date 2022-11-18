using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Cylinder : BaseShape
{

    // POLYMORPHISM
    protected override void MovingShape()
    {
        Speed = 500.0f;
        base.MovingShape();
        messageText += $"{nameof(MovingShape)} of {this.name} class\r\n";
        ChangeColor();
    }
    private void ChangeColor()
    {
        Color next = new Color(GenerateColorValue(), GenerateColorValue(), GenerateColorValue(), GenerateColorValue());
        GetComponent<Renderer>().material.color = next;
    }
    // ABSTRACTION
    private float GenerateColorValue()
    {
        return Random.Range(0.5f, 1.0f);
    }
}
