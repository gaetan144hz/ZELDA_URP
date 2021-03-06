using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    private inventaire _inventaire;
    
    void Start()
    {
        _inventaire = FindObjectOfType<inventaire>();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _inventaire.source.clip = _inventaire.sounds[2];
            _inventaire.source.Play();
            _inventaire.canOpen = true;
            Destroy(this.gameObject);
        }
    }
}
