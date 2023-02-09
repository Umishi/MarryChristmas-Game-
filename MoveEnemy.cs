using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveEnemy : MonoBehaviour
{
    bool StopCheck = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!StopCheck)
        {
            this.gameObject.transform.Translate(0.050f, 0, 0);
        }

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="Player")
        {
            SceneManager.LoadScene("Dead");
        }
    }

    public void StopEnemy()
    {

        StopCheck = true;

    }

}
