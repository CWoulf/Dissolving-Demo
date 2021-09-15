using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{
    public float min;
    public float max;
    public float seconds;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var newScale = Mathf.Lerp(min, max, Time.deltaTime * seconds);
        transform.localScale = new Vector3(newScale, newScale, newScale);
    }
}
