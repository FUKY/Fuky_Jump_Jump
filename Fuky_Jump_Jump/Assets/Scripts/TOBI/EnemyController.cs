using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

    private Animator _enemyAnimator;

    private Rigidbody2D _rb2dEnemy;

    public GameObject objectBom;

    public float speed;

    void Start()
    {
        _enemyAnimator = GetComponent<Animator>();
        _rb2dEnemy = GetComponent<Rigidbody2D>();
        _rb2dEnemy.velocity = new Vector2(-speed, 0f);

    }

    void Update()
    {

        if (_rb2dEnemy.position.x <= 1.6f)
        {
            Attack();
        }
        if (_rb2dEnemy.position.x >= 4f)
        {
            FlipRight();
        }
        //Debug.Log(_rb2dEnemy.velocity);
    }

    public void Attack()
    {
        _enemyAnimator.SetBool("isAttack", true);
        _rb2dEnemy.velocity = Vector2.zero;
    }

    public void FlipLeft()
    {
        _rb2dEnemy.velocity = new Vector2(speed, 0f);
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;

        _enemyAnimator.SetBool("isAttack", false);
    }

    public void FlipRight()
    {
        _rb2dEnemy.velocity = new Vector2(-speed, 0f);
        Vector3 theScale = transform.localScale;
        theScale.x = -theScale.x;
        transform.localScale = theScale;
    }

    public void CreateBom()
    {
       // Instantiate(objectBom, new Vector3(transform.position.x - 1,transform.position.y - 0.18 ,transform.position.z),transform.rotation);
        Instantiate(objectBom, new Vector3(transform.position.x -1 ,transform.position.y ,transform.position.z), transform.rotation);
    }

    

}
