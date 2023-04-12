using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCollision : MonoBehaviour
{
    public ParticleSystem part;
    public List<ParticleCollisionEvent> collisionEvents;

    void Start()
    {
        part = GetComponent<ParticleSystem>();
        Debug.Log(part);
        // collisionEvents = new List<ParticleCollisionEvent>();
    }

    void OnParticleCollision(GameObject other)
    {
        // I want to only use the last collision! It triggers multiple
        // because I don't kill them? How to only trigger once/only use last?
       Debug.Log("Particle collided!");
    }
}
