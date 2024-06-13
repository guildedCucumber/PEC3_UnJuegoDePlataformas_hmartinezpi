using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DayNightManager : MonoBehaviour
{
    public Text text;
    public Text text_shadow;
    public GameObject directional;
    public float totalSecondsTo16hours = 90;
    public float startDayRotationX = 0;
    public float endDayRotationX = 270;
    public float secondsLeft;

    float elapsedTime = 0;

    GameManager gameManager;

    void Start ()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        Reset();
    }

    void Update ()
    {
        elapsedTime += Time.deltaTime;
        secondsLeft = totalSecondsTo16hours - elapsedTime;
        
        float rot = (endDayRotationX - startDayRotationX) / totalSecondsTo16hours;
        directional.transform.Rotate(-rot * Time.deltaTime, 0, 0);

        SetText();

        if (secondsLeft < 0)
        {
            gameManager.ResetGame();
            Time.timeScale = 0;
        }
    }

    void SetText()
    {
        float secondsXHour = totalSecondsTo16hours / 16.0f;

        int hour = (int)((totalSecondsTo16hours - secondsLeft) / secondsXHour);
        int minutes = (int)((((totalSecondsTo16hours - secondsLeft) / secondsXHour) - hour) * 60);

        string label;

        if ((hour + 8) > 12)
            label = (hour + 8 - 12).ToString("00") + ":" + minutes.ToString("00") + "F G";
        else
            label = (hour + 8).ToString("00") + ":" + minutes.ToString("00") + "E G";

        text.text = text_shadow.text = label;
    }

    public void Reset()
    {
        totalSecondsTo16hours--;
        elapsedTime = 0;
        directional.transform.rotation = Quaternion.Euler(startDayRotationX,
            directional.transform.rotation.eulerAngles.y,
            directional.transform.rotation.eulerAngles.z);
    }
}
