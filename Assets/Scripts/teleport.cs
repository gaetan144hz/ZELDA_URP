using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class teleport : MonoBehaviour
{
    public GameObject Player;
    public CharacterController controller;
    public Transform tpTarget;
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        controller.enabled = false;
        other.gameObject.transform.position = tpTarget.position;
        other.gameObject.transform.rotation = tpTarget.rotation;
        controller.enabled = true;
    }
}
