using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    

    [SerializeField] Rigidbody _rd;
    public bool isStop = false;
    public int Speed = 0;


    void Awake()
    {
        _rd = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        MoveO();
    }

    void MoveO()
    {
        var front = -transform.right;
        float z = Input.GetAxis("Horizontal");
        Vector3 direction = _rd.transform.forward * z + front;
        if (isStop == false)
        {
            _rd.velocity = direction * Speed;
            
        }
        else if (isStop == true)
        {
            _rd.velocity = front * 0;
        }
    }
    private void OnTriggerStay(Collider other)
    {
      
        if (other.gameObject.name == "Gool")
        {
            isStop = true;
        }
    }
    
}
