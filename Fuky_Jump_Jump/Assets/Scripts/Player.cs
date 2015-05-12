using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    private Animator _playerAnimator;
    private Rigidbody2D _rb2d;

    private bool _grounded;
    //private Collider2D[] _groundedList;

    public Transform groundCheck;
    public LayerMask layerGround;

    void Start()
    {
        _playerAnimator = GetComponent<Animator>();
        _rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        _grounded = Physics2D.OverlapCircle(groundCheck.position, 0.1f, layerGround);
       // _groundedList=Physics2D.OverlapCircleAll(groundCheck.position,0.1f, layerGround);

    }

    public void Jump()
    {
        if (_grounded == true)
        {
            _playerAnimator.SetTrigger("jumpPlayer");
            _rb2d.AddForce(new Vector2(0f, 400f));
        }
    }


    public void Down()
    {
        if (_grounded == true)
        {
            _playerAnimator.SetTrigger("downPlayer");
        }
    }

    public void JumpFar()
    {
        if (_grounded == true)
        {
            _playerAnimator.SetTrigger("jumpPlayer");
            _rb2d.AddForce(new Vector2(400f, 700f));
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "DeathArea") 
        {
            _rb2d.gravityScale = 0f;
            _rb2d.velocity = Vector2.zero;
            _playerAnimator.SetTrigger("diePlayer");
        }
    }

    public void DestroyPlayer()
    {
        Destroy(gameObject);
    }

}
