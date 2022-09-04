using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterSpout : MonoBehaviour
{
    [SerializeField] private int _speed;

    private GameObject currentBoulder;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Boulder"))
        {
            other.GetComponent<Rigidbody>().useGravity = false;
            other.GetComponent<Rigidbody>().AddForce(Vector3.up * 9.81f * _speed, ForceMode.Acceleration);
            currentBoulder = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Boulder"))
        {
            other.GetComponent<Rigidbody>().useGravity = true;
            other.GetComponent<Rigidbody>().AddForce(Vector3.left * 3, ForceMode.Impulse);
            currentBoulder = null;
        }
    }
}
