using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatControl : MonoBehaviour {

    public float batSpeed = .1f;
    Rigidbody2D rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () 
    {
        // ################## PC Controlls ################################
        if (Input.GetAxis("Horizontal")!=0)
        {
            if (Input.GetAxis("Horizontal")>0)
            {
                transform.Translate(new Vector2(batSpeed, 0));
            }
            else
            {
                transform.Translate(new Vector2(-batSpeed, 0));
            }
        }
        //################################################################

    }

    //################### Phone Controlls ###########################
    public void PressedLeft()
    {
        //transform.Translate(new Vector2(-batSpeed, 0));
        rb.MovePosition(new Vector2(-batSpeed, 0));
    }
    public void PressedRight()
    {
        //transform.Translate(new Vector2(batSpeed, 0));
        rb.MovePosition(new Vector2(batSpeed, 0));
    }
}
