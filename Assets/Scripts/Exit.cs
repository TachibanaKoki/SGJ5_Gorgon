using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tobii.EyeTracking;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour {

    public float FlameCount = 240;
    private GazeAware m_GazeAware;

    // Use this for initialization
    void Start () {
        m_GazeAware = GetComponent<GazeAware>();

    }

    // Update is called once per frame
    void Update () {
        if (m_GazeAware.HasGazeFocus)
        {
            FlameCount--;
            if (FlameCount <= 0)
            {
                Application.Quit();
            }

            // ボタンの色を変える
            float changeRed = 0.0f;
            float changeGreen = 0.0f;
            float cahngeBlue = 1.0f;
            float cahngeAlpha = 1.0f;
            this.GetComponent<SpriteRenderer>().color = new Color(changeRed, changeGreen, cahngeBlue, cahngeAlpha);

        }
        else
        {
            FlameCount = 240;

            // ボタンの色を戻す
            float changeRed = 1.0f;
            float changeGreen = 1.0f;
            float cahngeBlue = 1.0f;
            float cahngeAlpha = 1.0f;
            this.GetComponent<SpriteRenderer>().color = new Color(changeRed, changeGreen, cahngeBlue, cahngeAlpha);

        }

    }
}
