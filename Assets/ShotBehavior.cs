using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotBehavior : MonoBehaviour
{
    public ParticleSystem particleSystem;

    private void OnCollisionEnter(Collision collision)
    {
        particleSystem.transform.parent = null;
        particleSystem.Play();
        Destroy(gameObject);
    }
}
