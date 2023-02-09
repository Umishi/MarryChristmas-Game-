using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWarp1 : MonoBehaviour
{
    public GameObject Player;
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
            Vector3 pos = Player.transform.position;
            Player.transform.position = new Vector3(pos.x + 10f, pos.y, pos.z);
            OneCheck = true;
        }
    }
}
