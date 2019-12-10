using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarningWallHit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        this.GetComponent<MeshRenderer>().enabled = true;
        this.GetComponent<MeshRenderer>().material.SetColor("_Color", Color.yellow);

    }
}
