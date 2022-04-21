using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Cinemachine;

public class interact : MonoBehaviour
{
    public GameObject text;
    public CinemachineVirtualCamera cvCam;
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Press E");
            cvCam.m_Priority = 11;
            text.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Stop"); 
            cvCam.m_Priority = 9;
            text.SetActive(false);
        }
    }
}
