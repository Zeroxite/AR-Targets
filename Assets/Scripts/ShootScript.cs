using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    public GameObject arCamera;
    AudioSource fuentedeaudio;
    public AudioClip audiopop;

    public void Shoot()
    {
        RaycastHit hit;
        fuentedeaudio = GetComponent<AudioSource>();
        if(Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out hit))
        {
            if (hit.transform.name == "Target(Clone)")
            {
                Destroy(hit.transform.gameObject);
                fuentedeaudio.clip = audiopop;
                fuentedeaudio.Play();
            }
        }
    }
}
