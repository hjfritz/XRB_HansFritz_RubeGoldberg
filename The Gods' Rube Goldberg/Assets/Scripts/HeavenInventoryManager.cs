using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeavenInventoryManager : MonoBehaviour
{
    [SerializeField] private GameObject _waterSpoutInvPrefab;
    [SerializeField] private GameObject _railsInvPrefab;
    [SerializeField] private GameObject _eIHeadInvPrefab;
    
    [SerializeField] private Transform _waterSpoutInvPosition;
    [SerializeField] private Transform _railsInvPosition;
    [SerializeField] private Transform _eIHeadInvPosition;
    
    [SerializeField] private GameObject _waterSpoutPrefab;
    [SerializeField] private GameObject _railsPrefab;
    [SerializeField] private GameObject _eIHeadPrefab;

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
        if (other.CompareTag("head") || other.CompareTag("rails") || other.CompareTag("spout"))
        {
            other.gameObject.SetActive(false);
        }
    }

    public void CreateHead()
    {
        Instantiate(_eIHeadPrefab, _eIHeadInvPosition);
    }
    
    public void CreateSpout()
    {
        Instantiate(_waterSpoutPrefab, _waterSpoutInvPosition);
    }
    
    public void CreateRails()
    {
        Instantiate(_railsPrefab, _railsInvPosition);
    }

    //private void OnTriggerExit(Collider other)
    //{
    //    if (other.CompareTag("head"))
    //    {
    //        var pos = other.transform;
    //        other.gameObject.SetActive(false);
    //        Instantiate(_eIHeadPrefab, );
    //        Instantiate(_eIHeadInvPrefab, _eIHeadInvPosition);
    //    }
    //    
    //    if (other.CompareTag("rails"))
    //    {
    //        var pos = other.transform;
    //        other.gameObject.SetActive(false);
    //        Instantiate(_railsPrefab, pos);
    //        Instantiate(_railsInvPrefab, _railsInvPosition);
    //    }
    //    
    //    if (other.CompareTag("spout"))
    //    {
    //        var pos = other.transform;
    //        other.gameObject.SetActive(false);
    //        Instantiate(_waterSpoutPrefab, pos);
    //        Instantiate(_waterSpoutInvPrefab, _waterSpoutInvPosition);
    //    }
    //}
}
