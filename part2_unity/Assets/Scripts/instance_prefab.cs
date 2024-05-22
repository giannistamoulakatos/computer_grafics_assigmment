using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instance_prefab : MonoBehaviour
{
    public GameObject assigmentPrefab;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(assigmentPrefab,new Vector3(0,24,0),Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
