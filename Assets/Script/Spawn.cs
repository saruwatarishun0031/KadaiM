using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] GameObject PrefabCube;

    float x = 300;
    float z = 0;
    float y = 4;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 11; i++)
        {
            
            Vector3 pos = new Vector3(x -= 50,y,z);
            Instantiate(PrefabCube, pos, Quaternion.identity);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
