using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class BlueShape : Shape
{
    // ENCAPSULATION
    [field: SerializeField]
    public override string ShapeName { get; set; }

    // POLYMORPHISM
    public override string PrintText()
    {
        return $"{ShapeName} was clicked on";
    }
}
