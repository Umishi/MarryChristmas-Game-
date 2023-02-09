using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPop : MonoBehaviour
{
    [SerializeField] AudioClip SE = null;
    AudioSource Audio;
    public GameObject enemy;

    bool OnceCheck = false;
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
        if (!OnceCheck)
        {
            Audio = GetComponent<AudioSource>();
            Audio.PlayOneShot(SE);
            enemy.SetActive(true);
            OnceCheck = true;
        }
    }
}
