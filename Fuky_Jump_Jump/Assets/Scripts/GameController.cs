using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    //
    public GameObject player;
    public GameObject playerPrefab;
    public Transform playerPosition;
    //

    public void Start()
    {
    }

    public void GameReStart()
    {

    }

    //Khoi tao game
    public void GameInit()
    {
        //Tao player
        if (player == null)
        {
            player = Instantiate(playerPrefab);
            player.transform.position = playerPosition.position;
            player.transform.SetParent(playerPosition);
        }
        else
        {
            //Reset lai gia tri
        }

        //Tao enemy

    }

    public void GameUpdate()
    {
        //Kiem tra neu chet
        if (true)
        {
            //Load man hinh thua len
        }
    }

    //Cong diem
    public void AddScore(int score)
    {
        //Cong diem
        ScoreController.Instance.ShowScore(score);
    }

    public void Jump()
    {
        if (player)
            player.GetComponent<Player>().Jump();
    }
    public void JumpFar()
    {
        if (player)
            player.GetComponent<Player>().JumpFar();
    }

    public void Down()
    {
        if (player)
            player.GetComponent<Player>().Down();
    }

}
