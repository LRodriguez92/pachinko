using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOnTrigger : MonoBehaviour
{
    ParticleSystem particleObject;

    void OnTriggerEnter2D(Collider2D collision)
    {
        particleObject = GetComponent<ParticleSystem>();
        particleObject.Play();

    }
}
