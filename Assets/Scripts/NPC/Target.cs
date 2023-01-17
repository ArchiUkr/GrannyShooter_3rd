using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField]
    private GameObject target;
    private float health = 5;

    private void Update()
    {
        if(health < 0)
        {
            target.SetActive(false);
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Bullet")
        {
            health = health - 1;
        }
    }

}
