using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pressed : MonoBehaviour {


    public bool isLeft = true;
    public bool pressed = false;
    public BatControl bc;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (pressed && isLeft)
        {
            bc.PressedLeft();
        }
        else if(pressed && !isLeft)
        {
            bc.PressedRight();
        }
	}

    public void OnPointerDown()
    {
        pressed = true;
    }
    public void OnPointerUp()
    {
        pressed = false;
    }
}
