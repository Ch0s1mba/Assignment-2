using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    public Button button;

    private void Awake()
    {
        Time.timeScale = 0f;
    }
    private void Start() //just a start button
	{

        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        
    }

    void TaskOnClick()
    {
        print("Game Starts");
        Time.timeScale = 1f;
    }

}
