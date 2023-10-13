using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class call : MonoBehaviour
{
    public GameObject function;
    // Start is called before the first frame update
    void Start()
    {
        function.GetComponent<scrit>().TestFunction();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
