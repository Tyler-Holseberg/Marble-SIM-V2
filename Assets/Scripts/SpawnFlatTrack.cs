using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFlatTrack : MonoBehaviour
{
    public Object item;
    private int count;
    public int max;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        count = GameObject.FindGameObjectsWithTag("Flat").Length;
        if (count <= max)
        {
            Instantiate(item, this.transform);
        }
    }
}
