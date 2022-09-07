using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterSpout : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform _entrance;
    [SerializeField] private float margin;
    
    private GameObject currentBoulder;
    private bool boulderUp = false;
    private bool atEntrance = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (boulderUp)
        {
            if (Vector3.Distance(currentBoulder.transform.position, _entrance.position) < margin)
            {
                atEntrance = true;
            }

            if (atEntrance)
            {
                currentBoulder.GetComponent<Rigidbody>().AddForce(Vector3.up * 9.81f * _speed, ForceMode.Acceleration);
            }
            else
            {
                currentBoulder.transform.position = _entrance.position;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Boulder") || other.CompareTag("head"))
        {
            other.GetComponent<Rigidbody>().velocity = Vector3.zero;
            other.GetComponent<Rigidbody>().useGravity = false;
            boulderUp = true;
            currentBoulder = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Boulder") || other.CompareTag("head"))
        {
            other.GetComponent<Rigidbody>().useGravity = true;
            other.GetComponent<Rigidbody>().AddForce(Vector3.left * 3, ForceMode.Impulse);
            currentBoulder = null;
            boulderUp = false;
            atEntrance = false;
        }
    }
}
