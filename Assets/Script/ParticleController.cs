using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour
{
    public GameObject ParticlePf;
    Vector3 ParticleOrientation = new Vector3(-90, 0, 0);


    private void OnCollisionEnter(Collision collision)
    {
        GameObject Particle = Instantiate(ParticlePf,collision.contacts[0].point,Quaternion.Euler(ParticleOrientation));

        Destroy(Particle, 2);

        ParticleSystem ps = Particle.GetComponent<ParticleSystem>();
        ParticleSystem.EmissionModule emissionModule = ps.emission;

        float collisionIntensity = collision.relativeVelocity.magnitude * 100;
        if(collisionIntensity > 1000){
            collisionIntensity = 1000;
        }

        emissionModule.rateOverTime = collisionIntensity;

    }

    
}
