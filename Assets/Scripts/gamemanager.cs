using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class gamemanager : MonoBehaviour
{
    public enum playerstate
    {
        player1,
        player2
    }

    private playerstate currentplayer;

    public GameObject[] cells;
    public TMP_Text[] texts;

    public TMP_Text statusText;

    private int turn = 0;

    
    void Start()
    {
        for (int i = 0; i < cells.Length; i++)
        {
            texts[i].text = "";
        }
        statusText.text = "Player X turn";

        currentplayer = playerstate.player1;

    }

    // void Update()
    // {

    // }

    public void onclick(int index)
    {

        if (texts[index].text == "" && !checkWin())
        {
            if (currentplayer == playerstate.player1)
            {
                texts[index].text = "X";
                turn+=1;
                currentplayer = playerstate.player2;
                statusText.text = "Player O turn";
                // if (checkWin())
                // {
                //     statusText.text = "player X won";
                // }
                if (!checkWin() && turn == 9)
                {
                    statusText.text = "its draw, try again";
                }else if(checkWin()){
                    statusText.text = "player X won";
                }
            }
            else
            {
                texts[index].text = "O";
                turn+=1;
                currentplayer = playerstate.player1;
                statusText.text = "Player X turn";
                // checkWin();
                // if (checkWin())
                // {
                //     statusText.text = "player O won";
                // }
                if (!checkWin() && turn == 9)
                {
                    statusText.text = "its draw, try again";
                }
                else if(checkWin()){
                    statusText.text = "player O won";
                }
            }
        }


    }

    bool checkWin()
    {
        //horizontal
        if ((texts[0].text == "O" && texts[1].text == "O" && texts[2].text == "O") || (texts[0].text == "X" && texts[1].text == "X" && texts[2].text == "X"))
        {
            return true;
        }
        else if ((texts[3].text == "O" && texts[4].text == "O" && texts[5].text == "O") || (texts[3].text == "X" && texts[4].text == "X" && texts[5].text == "X"))
        {
            return true;
        }
        else if ((texts[6].text == "O" && texts[7].text == "O" && texts[8].text == "O") || (texts[6].text == "X" && texts[7].text == "X" && texts[8].text == "X"))
        {
            return true;
        }

        //vertical
        else if ((texts[0].text == "O" && texts[3].text == "O" && texts[6].text == "O") || (texts[0].text == "X" && texts[3].text == "X" && texts[6].text == "X"))
        {
            return true;
        }
        else if ((texts[1].text == "O" && texts[4].text == "O" && texts[7].text == "O") || (texts[1].text == "X" && texts[4].text == "X" && texts[7].text == "X"))
        {
            return true;
        }
        else if ((texts[2].text == "O" && texts[5].text == "O" && texts[8].text == "O") || (texts[2].text == "X" && texts[5].text == "X" && texts[8].text == "X"))
        {
            return true;
        }

        //diagonal
        else if ((texts[0].text == "O" && texts[4].text == "O" && texts[8].text == "O") || (texts[0].text == "X" && texts[4].text == "X" && texts[8].text == "X"))
        {
            return true;
        }
        else if ((texts[2].text == "O" && texts[4].text == "O" && texts[6].text == "O") || (texts[2].text == "X" && texts[4].text == "X" && texts[6].text == "X"))
        {
            return true;
        }

        else
        {
            return false;
        }
    }

    public void Reset()
    {
        for(int i =0; i <cells.Length; i ++)
        {
            texts[i].text = "";
            statusText.text = "";
        }
    }


}
