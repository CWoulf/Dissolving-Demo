using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartOnFire : MonoBehaviour
{
    [SerializeField] Material mat;
    [SerializeField] Material defaultmat;
    [SerializeField] ParticleSystem fire;
    bool isOnFire = false;
    

    void Update()
    {
        if(Input.GetKey(KeyCode.Space) && !fire.isPlaying)
        {
            fire.Play();
            Debug.Log("Burn Mat");
            GetComponent<MeshRenderer>().material = mat;
        }
        else if (fire.isPlaying && Input.GetKey(KeyCode.Space))
        {
            fire.Clear();
            fire.Pause();
        }
    }
    
}
