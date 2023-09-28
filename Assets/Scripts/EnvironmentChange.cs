using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class EnvironmentChange : MonoBehaviour
{
    [SerializeField] private EnvironmentConfig envConfig;
    [Header("Sky")]
    [SerializeField] private GameObject _sky;
    [SerializeField] private GameObject _sun;
    [SerializeField] private GameObject _clouds;
    [Header("Ground")]
    [SerializeField] private GameObject _ground;
    [Header("Objects")]
    [SerializeField] private GameObject _grass;
    [SerializeField] private GameObject _flower;
    [SerializeField] private GameObject _leaf;
    [SerializeField] private GameObject _trees;
    [SerializeField] private GameObject _rocks;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void InitEnvironment(string currentEnvironment)
    {

    }

}

