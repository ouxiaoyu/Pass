using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIAdapter : MonoBehaviour
{
    public GameObject scorePanel;
    public GameObject pausePanel;
    public GameObject resumeButton;
    public GameObject settingPanel;    
    public GameObject settingButton;
    public GameObject failPanel;
    public GameObject leftButton;
    public GameObject rightButton;
    public GameObject perfect;
    public GameObject canvas;

    void Update()
    {
        if (Screen.orientation == ScreenOrientation.Portrait)
        {
            scorePanel.transform.localScale = new Vector3(0.5f, 0.5f, 1f);
            scorePanel.transform.localPosition = new Vector3(80, 130, 0);
            pausePanel.transform.localScale = new Vector3(1, 1, 1);
            pausePanel.transform.localPosition = new Vector3(100, 180, 0);
            resumeButton.transform.localScale = new Vector3(1, 1, 1);
            resumeButton.transform.localPosition = new Vector3(100, 180, 0);
            settingButton.transform.localScale = new Vector3(1, 1, 1);
            settingButton.transform.localPosition = new Vector3(100, 220, 0);
            leftButton.transform.localScale = new Vector3(1, 1, 1);
            leftButton.transform.localPosition = new Vector3(-60, -190, 0);
            rightButton.transform.localScale = new Vector3(1, 1, 1);
            rightButton.transform.localPosition = new Vector3(60, -190, 0);
            settingPanel.transform.localScale = new Vector3(0.5f, 0.5f, 1f);
            failPanel.transform.localScale = new Vector3(0.5f, 0.5f, 1f);
            perfect.transform.localScale = new Vector3(2, 1, 1);
            canvas.GetComponent<CanvasScaler>().screenMatchMode = CanvasScaler.ScreenMatchMode.MatchWidthOrHeight;

        }
        if (Screen.orientation == ScreenOrientation.Landscape)
        {
            scorePanel.transform.localScale = new Vector3(1, 1, 1);
            scorePanel.transform.localPosition = new Vector3(0, 0, 0);
            pausePanel.transform.localScale = new Vector3(2, 2, 1);
            pausePanel.transform.localPosition = new Vector3(280, 200, 0);
            resumeButton.transform.localScale = new Vector3(2, 2, 1);
            resumeButton.transform.localPosition = new Vector3(280, 200, 0);
            settingButton.transform.localScale = new Vector3(2, 2, 1);
            settingButton.transform.localPosition = new Vector3(370, 200, 0);
            leftButton.transform.localScale = new Vector3(1.5f, 1.5f, 1f);
            leftButton.transform.localPosition = new Vector3(-300, -190, 0);
            rightButton.transform.localScale = new Vector3(1.5f, 1.5f, 1f);
            rightButton.transform.localPosition = new Vector3(300, -190, 0);
            settingPanel.transform.localScale = new Vector3(1, 1, 1);
            failPanel.transform.localScale = new Vector3(1, 1, 1);
            perfect.transform.localScale = new Vector3(4, 2, 1);
            canvas.GetComponent<CanvasScaler>().screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
        }
    }
}
