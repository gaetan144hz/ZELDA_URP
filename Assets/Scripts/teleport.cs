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

    private inventaire _inventaire;
    public GameObject notAllowed;

    public CinemachineVirtualCamera cvCamINT;
    [SerializeField] private int CamPriority;
    
    void Start()
    {
        _inventaire = FindObjectOfType<inventaire>();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (_inventaire.count == 3)
        {
            controller.enabled = false;
            cvCamINT.m_Priority = CamPriority;
            other.gameObject.transform.position = tpTarget.position;
            other.gameObject.transform.rotation = tpTarget.rotation;
            controller.enabled = true;
        }
        else
        {
            notAllowed.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        notAllowed.SetActive(false);
    }
}
