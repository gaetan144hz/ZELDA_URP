using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour
{
    private inventaire _inventaire;

    private void Start()
    {
        _inventaire = FindObjectOfType<inventaire>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject,0.1f);
    }

    private void OnDestroy()
    {
        _inventaire.takeKey();
    }
}
