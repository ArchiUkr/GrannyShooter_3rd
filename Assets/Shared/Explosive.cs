using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosive : MonoBehaviour
{
    public GameObject Barrel, Explosion;

    private AudioSource sourse;
    public float range;

    private void Awake()
    {
        Barrel.SetActive(true);
        Explosion.SetActive(false);

        sourse = GetComponent<AudioSource>();
    }

    public void Explode()
    {
        Barrel.SetActive(false);
        Explosion.SetActive(true);

        sourse.Play();

        Collider[] enemies = Physics.OverlapSphere(transform.position, range);

        foreach(Collider enemy in enemies)
        {
            if (enemy.GetComponent<EnemyHealth>() != null)
            {
                enemy.GetComponent<EnemyHealth>().Die();
            }
        }

        //sourse.Play();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Explode();
        }
        
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawSphere(transform.position, range);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Bullet")
        {
            Explode();
        }
    }
}
