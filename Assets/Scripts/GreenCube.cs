using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenCube : Parent
{
    //OVERRIDE parent name to name of the cube
    public override void DisplayName()
    {
        nameText.text = ("Green Cube");
    }
    
    //INHERITE the parent method
    private void OnMouseDown()
    {
        WhenYouClick();
    }
}
