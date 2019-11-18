using UnityEngine;
using System.Collections;
using System;

public class Bomb : MonoBehaviour
{
    public GameObject explosionParticlesPrefab;

    // Use this for initialization
    void Start ()
    {
        float randomX = UnityEngine.Random.Range(10f, 100f);
        float randomY = UnityEngine.Random.Range(10f, 100f);
        float randomZ = UnityEngine.Random.Range(10f, 100f);

        Rigidbody bomb = GetComponent<Rigidbody>();
        bomb.AddTorque(randomX, randomY, randomZ);
    }
        
    public void OnCollisionEnter (Collision collision)
    {
        if (explosionParticlesPrefab)
        {
            GameObject explosion = (GameObject)Instantiate (explosionParticlesPrefab, transform.position, explosionParticlesPrefab.transform.rotation);
            Destroy (explosion, explosion.GetComponent<ParticleSystem> ().main.startLifetimeMultiplier);
        }

        Destroy (gameObject);
    }

}
