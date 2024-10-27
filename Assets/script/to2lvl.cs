using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class to2lvl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        Application.LoadLevel("lvl1e");

    }
}
