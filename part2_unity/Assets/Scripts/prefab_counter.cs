using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class prefab_counter : MonoBehaviour
{   
    public GameObject assigment_prefab_12;
    public int prefabclonecounter;
    public Text prefab_counter_text;
    public float spawn = 1f;
    private List<GameObject> prefabcloneobjects = new List<GameObject>();
    private float spawn_prefab= 0f;
   
    // Start is called before the first frame update
    void Start()
    {
        prefabclonecounter=0;
        prefab_counter_text.text="clone prefab= " + prefabclonecounter;
    }



    void clone_prefab()
    {
        Instantiate(assigment_prefab_12,transform.position,Quaternion.identity);
        prefabclonecounter = prefabclonecounter+1;
        prefab_counter_text.text="clone prefab= "+ prefabclonecounter;
    }

    // Update is called once per frame
    void Update()
    {
        spawn_prefab=spawn_prefab+Time.deltaTime;
        if (spawn_prefab >= spawn)
        {
            spawn_prefab = 0f;
            GameObject clone = Instantiate(assigment_prefab_12, transform.position, Quaternion.identity);
            prefabcloneobjects.Add(clone);
            prefab_counter_text.text = "Cloned prefab: " + prefabcloneobjects.Count;
        }

    }
}
