using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartOnFire : MonoBehaviour
{
    [SerializeField] Material mat;
    [SerializeField] ParticleSystem fire;
    bool isOnFire = false;

    private void Start()
    {
        //StartCoroutine(StartFire());
    }

    IEnumerator StartFire()
    {
        fire.Play();
        yield return new WaitForSeconds(3f);
        fire.Clear();
        fire.Pause();
    }

    void Update()
    {
        /*
        if(Input.GetKey(KeyCode.Space) && !fire.isPlaying)
        {
            fire.Play();
        }
        else if (fire.isPlaying && Input.GetKey(KeyCode.Space))
        {
            fire.Clear();
            fire.Pause();
        }
        */
        //StartCoroutine(StartFire());
    }
    
}
