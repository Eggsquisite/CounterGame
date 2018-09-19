using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Number : MonoBehaviour {
    public Text myText;
    int randNum;
    public int myScore;

    void Start()
    {
        randNum = Random.Range(0, 9);

        if (randNum == 0) { myText.text = "0"; }
        else if (randNum == 1) { myText.text = "1"; }
        else if (randNum == 2) { myText.text = "2"; }
        else if (randNum == 3) { myText.text = "3"; }
        else if (randNum == 4) { myText.text = "4"; }
        else if (randNum == 5) { myText.text = "5"; }
        else if (randNum == 6) { myText.text = "6"; }
        else if (randNum == 7) { myText.text = "7"; }
        else if (randNum == 8) { myText.text = "8"; }
        else if (randNum == 9) { myText.text = "9"; }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
