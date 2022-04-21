using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;

public class interact : MonoBehaviour
{
    public GameObject text;
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void OnInteract(InputValue value)
    {
        if (value.isPressed)
        {
            text.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            text.SetActive(true);
            Debug.Log("Press E"); 
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Stop"); 
            text.SetActive(false);
        }
    }
}
