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



    void Start()
    {
        _inventaire = FindObjectOfType<inventaire>();
    }

    void Update()
    {
        
    }

    public void repare()
    {
        Instantiate(keyPrefabs, spwnPoint.position, Quaternion.identity);
        _inventaire.count = 0;
        _inventaire.counter.text = _inventaire.count.ToString("0");
        Destroy(this.gameObject);
    }
}
