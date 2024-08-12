using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Task : MonoBehaviour
{
    [SerializeField] private Image sprite;
    [SerializeField] private Text UIText;
    public bool isTaskComplete = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetTask(string taskName)
    {
        UIText.text = taskName;
    }

    public void OnTaskComplete()
    {
        sprite.color = Color.green;
        //UIText.text = "Task Complete";
        isTaskComplete = true;
    }

}
