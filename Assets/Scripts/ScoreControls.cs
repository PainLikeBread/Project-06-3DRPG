using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreControls : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int storevalue;

    public TextMeshProUGUI endText;

    // Update is called once per frame
    void Update()
    {
        storevalue = GameObject.Find("PlayerArmature").GetComponent<PlayerPickUp>().scoreInt;
        scoreText.SetText("Squirrels deposited " + storevalue + "/10");
        if (storevalue == 10){
            scoreText.gameObject.SetActive(false);
            endText.gameObject.SetActive(true);
        }
    }
}
