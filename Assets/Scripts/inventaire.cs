using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;

public class inventaire : MonoBehaviour
{
    public TextMeshProUGUI counter;
    public int count;
    public int oneKey;

    private reparation _reparation;
    private GameObject lastTriggerGameObject;
    
    public bool canOpen;
    
    void Start()
    {
        _reparation = FindObjectOfType<reparation>();
    }

    void Update()
    {
        
    }

    public void OnRepare(InputValue value)
    {
        if (value.isPressed || lastTriggerGameObject == null)
        {
            lastTriggerGameObject.GetComponent<reparation>();
            _reparation.repare();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("TableRepare"))
        {
            lastTriggerGameObject = other.gameObject;
            Debug.Log(("Press E"));
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("TableRepare"))
        {
            return;
        }
        lastTriggerGameObject = null;
    }

    public void takePartKey()
    {
        count += oneKey;
        counter.text = count.ToString("0");
    }
}
