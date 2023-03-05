using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class RedShape : Shape
{
    // ENCAPSULATION
    [field: SerializeField]
    public override string ShapeName { get ; set ; }

}
