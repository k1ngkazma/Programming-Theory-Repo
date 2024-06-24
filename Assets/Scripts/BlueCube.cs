using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueCube : Parent
{
    //OVERRIDE parent name to name of the cube
    public override void DisplayName()
    {
        nameText.text = ("Blue Cube LowJumper");
    }

    public override void JumpObjective()
    {
        
        rb_force = 5.0f;
        rb.AddForce(Vector3.up * rb_force, ForceMode.Impulse);

    }

    //INHERITE the parent method
    private void OnMouseDown()
    {
        WhenYouClick();
    }
}
