using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMPlay : MonoBehaviour
{
    [SerializeField] AudioClip BGM = null;
    AudioSource Audio;

    bool OneCheck = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (!OneCheck)
        {
            Audio = GetComponent<AudioSource>();
            Audio.PlayOneShot(BGM);
            OneCheck = true;
        }
    }
}

