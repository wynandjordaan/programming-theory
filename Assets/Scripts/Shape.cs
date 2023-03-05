using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    // ABSTRACTION
    public abstract string ShapeName { get; set; }

    public virtual string PrintText()
    {
        return $"Clicked on: {ShapeName}";
    }

    private void OnMouseDown()
    {

        var txtField = GameObject.Find("DisplayText").GetComponent<TMPro.TMP_Text>();
        txtField.text = PrintText();
    }

}
