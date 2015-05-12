using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    private Animator _playerAnimator;
    private Rigidbody2D _rb2d;

    private bool _grounded;

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
    }

    public void Jump()
    {
        if (_grounded == true)
        {
            _playerAnimator.SetTrigger("jumpPlayer");
            _rb2d.AddForce(new Vector2(0f, 350f));
        }
    }

}
