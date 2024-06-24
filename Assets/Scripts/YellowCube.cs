using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowCube : Parent
{
    //OVERRIDE parent name to name of the cube
    public override void DisplayName()
    {
        nameText.text = ("Yellow Cube HighJumper");
    }

    public override void JumpObjective()
    {
        rb_force = 12.0f;
        rb.AddForce(Vector3.up * rb_force, ForceMode.Impulse);
    }

    //INHERITE the parent method
    private void OnMouseDown()
    {
        WhenYouClick();
    }
}
