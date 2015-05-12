using UnityEngine;
using System.Collections;

public class GameController : MonoSingleton<GameController> {

    //
    public GameObject player;
    public GameObject playerPrefab;
    public Transform playerPosition;
    //
    

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
}
