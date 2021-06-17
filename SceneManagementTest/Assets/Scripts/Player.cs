using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAPI;

public class Player : NetworkBehaviour
{
    GameObject displayableObjects;
    private void Awake()
    {
        displayableObjects = GameObject.FindGameObjectWithTag("DisplayableObjects");
        gameObject.transform.parent = displayableObjects.transform;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
