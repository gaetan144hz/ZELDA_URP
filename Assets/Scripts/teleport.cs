using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class teleport : MonoBehaviour
{
    public GameObject Player;
    public CharacterController controller;
    public Transform tpTarget;

    public CinemachineVirtualCamera cvCamINT;
    [SerializeField] private int CamPriority;
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        controller.enabled = false;
        cvCamINT.m_Priority = CamPriority;
        other.gameObject.transform.position = tpTarget.position;
        other.gameObject.transform.rotation = tpTarget.rotation;
        controller.enabled = true;
    }
}
