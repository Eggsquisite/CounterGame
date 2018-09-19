using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class myNumber : MonoBehaviour {

    public Text myText;
    public Text myScore;
    int randNum;
    int score = 0;

    // Use this for initialization
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

    // Update is called once per frame
    void Update () {
        myScore.text = "Your Score: " + score;

        if (randNum == 0 && Input.GetKeyDown(KeyCode.Keypad0)) {
            score++;
            Destroy(obj: myText);
        }
        else if (randNum == 1 && Input.GetKeyDown(KeyCode.Keypad1)) {
            score++;
            Destroy(obj: myText);
        }
        else if (randNum == 2 && Input.GetKeyDown(KeyCode.Keypad2)) {
            score++;
            Destroy(obj: myText);
        }
        else if (randNum == 3 && Input.GetKeyDown(KeyCode.Keypad3)) {
            score++;
            Destroy(obj: myText);
        }
        else if (randNum == 4 && Input.GetKeyDown(KeyCode.Keypad4)) {
            score++;
            Destroy(obj: myText);
        }
        else if (randNum == 5 && Input.GetKeyDown(KeyCode.Keypad5)) {
            score++;
            Destroy(obj: myText);
        }
        else if (randNum == 6 && Input.GetKeyDown(KeyCode.Keypad6)) {
            score++;
            Destroy(obj: myText);
        }
        else if (randNum == 7 && Input.GetKeyDown(KeyCode.Keypad7)) {
            score++;
            Destroy(obj: myText);
        }
        else if (randNum == 8 && Input.GetKeyDown(KeyCode.Keypad8)) {
            score++;
            Destroy(obj: myText);
        }
        else if (randNum == 9 && Input.GetKeyDown(KeyCode.Keypad9)) {
            score++;
            Destroy(obj: myText);
        }
    }
}
