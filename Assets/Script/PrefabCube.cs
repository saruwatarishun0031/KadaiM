using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabCube : MonoBehaviour
{
    UIManajer UIM;

    // Start is called before the first frame update
    void Start()
    {
        //UIM = GetComponent<UIManajer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Sphere")
        {
            UIManajer.Instance.AddPoint(1);
            Destroy(this.gameObject);
        }
    }
}
