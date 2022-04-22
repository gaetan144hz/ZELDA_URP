using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class reparation : MonoBehaviour
{
    [Header("Inventaire")]
    private inventaire _inventaire;

    public GameObject keyPrefabs;
    public Transform spwnPoint;

    public bool canOpen;
    
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
            canOpen = true;
            Instantiate(keyPrefabs, spwnPoint.position, Quaternion.identity);
        }
    }
}
