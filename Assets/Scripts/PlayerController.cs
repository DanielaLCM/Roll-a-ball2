﻿using System.Collections;

using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;
    public Text countText;
    public Text winText;

    private Rigidbody rb;

    private int count;

  void Start ()
  {
      rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText ();
        winText.text = "";
        
    }
 
   void FixedUpdate ()
   {
        float moveHorizontal = Input.GetAxis ("Horizontal"); 
        float moveVertical = Input.GetAxis ("Vertical");
        
        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
        // Debug.Log (movement);

         rb.AddForce (movement * speed);
       // Vector3 movement = new Vector3(0.01f, 0.0f, 0.02f);
       
    }  
    void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }


    }
    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 13)
        {
            winText.text = "YOU WIN! =)";
        }
    }

}


