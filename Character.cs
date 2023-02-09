using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
 //プレーヤーを指定
    public GameObject Player;
    public AudioClip Footnote;


    //速度
    [SerializeField] float Speed;

    //物理
    private Rigidbody2D rb = null;

    //アニメーション
    private Animator Animation = null;

    //足音
    bool AudioIsPlaying=false;
    AudioSource Audio;

    // Start is called before the first frame update
    void Start()
    {
        //物理、アニメーションを取ってくる
        rb = Player.GetComponent<Rigidbody2D>();
        Animation = Player.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        UtageController u = GetComponent<UtageController>();
        if (!u.IsPlaying)
        {
            Move();
        }
        else if (u.IsPlaying)
        {
 
            rb.velocity = new Vector2(0, rb.velocity.y);
            Animation.SetBool("PlayerRun", false);

        }
    
    }

    void Move()
    {
        float CharaSpeed=0.0f;
        float HorizontalKey = Input.GetAxisRaw("Horizontal");
        Audio = GetComponent<AudioSource>();
        if (HorizontalKey < 0)
        {

            Animation.SetBool("PlayerRun", true);
            Player.transform.localScale = new Vector3(-1f, 1f, 1);
            CharaSpeed = -Speed;
            if (!AudioIsPlaying)
            {
                Debug.Log("hi");
                Audio.PlayOneShot(Footnote);
                AudioIsPlaying = true;
            }

        }

        else if (HorizontalKey > 0)
        {
            Animation.SetBool("PlayerRun", true);
            Player.transform.localScale = new Vector3(1f, 1f, 1);
            CharaSpeed = Speed;
            if (!AudioIsPlaying)
            {
                Audio.PlayOneShot(Footnote);
                AudioIsPlaying = true;
            }
        }

        else 
        {
            Animation.SetBool("PlayerRun", false);
            Audio.Stop();
            AudioIsPlaying = false;

        }
        rb.velocity = new Vector2(CharaSpeed, rb.velocity.y);

    }
}
