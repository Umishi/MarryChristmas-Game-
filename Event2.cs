using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Playables;
public class Event2 : MonoBehaviour
{
    public PlayableDirector playableDirector;

    public GameObject mizu;
    public GameObject mizu2;
    public GameObject tukaite1;

    public GameObject Enemy2;
    public GameObject Enemy3;

    public GameObject ChidameriEnshutu;
    MoveEnemy moveEnemy2;
    MoveEnemy moveEnemy3;

    bool OnceCheck = false;
    // Start is called before the first frame update
    void Start()
    {
        playableDirector = GetComponent<PlayableDirector>();
        moveEnemy2 = Enemy2.GetComponent<MoveEnemy>();
        moveEnemy3 = Enemy3.GetComponent<MoveEnemy>();

        mizu.SetActive(false);
        mizu2.SetActive(false);
        tukaite1.SetActive(false);
        ChidameriEnshutu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            PlayTimeline();
            moveEnemy2.StopEnemy();
            moveEnemy3.StopEnemy();


        }
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
