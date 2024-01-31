using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideController : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Pressed");
        }
    }
    //private void OnMouseDown()
    //{
    //    Debug.Log("Name = " + this.gameObject.name);
    //}
    public void DoSomethingOnClick()
    {
        // Your logic here
        if (this.gameObject.tag == "right")
        {
            Debug.Log("Left clicked");
            SlidingList.instance.SlideLeft();
        }
        else if(this.gameObject.tag == "left")
        {
            Debug.Log("Left clicked");
            SlidingList.instance.SlideRight();
        }
        else
        {
            Debug.Log("GameObject clicked!");
        }
    }
    
}
