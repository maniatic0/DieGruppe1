using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class pongManager : MonoBehaviour {
    private int scoreP1;
    private int scoreP2;
    public Text scoreBoardP1;
    public Text scoreBoardP2;

    public void Start() {
        resetScores();
    }

    public void increaseScoreP1() {
        scoreP1++;
        scoreBoardP1.text = scoreP1.ToString();
    }

    public void increaseScoreP2()
    {
        scoreP2++;
        scoreBoardP2.text = scoreP2.ToString();
    }

    public void resetScores() {
        scoreP1 = 0;
        scoreP2 = 0;
        scoreBoardP1.text = scoreP1.ToString();
        scoreBoardP2.text = scoreP2.ToString();
    }
}
