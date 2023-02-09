using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Playables;
public class Event1 : MonoBehaviour
{
    public PlayableDirector playableDirector;

    bool OnceCheck = false;
    // Start is called before the first frame update
    void Start()
    {
        playableDirector = GetComponent<PlayableDirector>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        PlayTimeline();
    }


    void PlayTimeline()
    {
        if (!OnceCheck)
        {
            playableDirector.Play();
            OnceCheck = true;
        }
    }
}
