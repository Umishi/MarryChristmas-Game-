using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
 //�v���[���[���w��
    public GameObject Player;
    public AudioClip Footnote;


    //���x
    [SerializeField] float Speed;

    //����
    private Rigidbody2D rb = null;

    //�A�j���[�V����
    private Animator Animation = null;

    //����
    bool AudioIsPlaying=false;
    AudioSource Audio;

    // Start is called before the first frame update
    void Start()
    {
        //�����A�A�j���[�V����������Ă���
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
