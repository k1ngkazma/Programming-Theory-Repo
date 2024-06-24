using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Parent : MonoBehaviour
{
   
    //rigid body variable
    public Rigidbody rb;

    //for upward force
    private float rbForce = 10.0f;
    //ENCAPSULATION
    public float rb_force
    {
        get { return rbForce; }
        set
        {
            if (value > 15.0f || value < 3.0f)
            {
                Debug.LogError("the force value is out of range");
            }
            else
            {
                rbForce = value;
            }
        }

    }
    public TMP_Text nameText;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        WhenYouClick();
    }

    //ABSTRACTION
    public void WhenYouClick()
    {
        JumpObjective();
        DisplayName();


    }
    public virtual void DisplayName()
    {
        nameText.text = ("Parent Cube");
    }

    public virtual void JumpObjective()
    {  
        rb.AddForce(Vector3.up * rb_force, ForceMode.Impulse);
    }
}
