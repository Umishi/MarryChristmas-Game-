using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("EndCoroutine");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator EndCoroutine() 
    {

        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene("Roji");

    }



}
