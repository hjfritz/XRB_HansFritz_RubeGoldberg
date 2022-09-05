using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    [SerializeField] private GameObject _boulderChild;
    [SerializeField] private GameObject _balloonChild;
    [SerializeField] private GameObject _ropeChild;
    
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
        _balloonChild.SetActive(false);
        _ropeChild.SetActive(false);
        _boulderChild.GetComponent<Rigidbody>().isKinematic = false;
        _boulderChild.GetComponent<Rigidbody>().useGravity = true;
    }
}
