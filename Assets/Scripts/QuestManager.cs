using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public static QuestManager instance;
    public Task[] tasks;
    private int enemyKill; 
    private int turrentOnMap; 

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        tasks[0].SetTask("Click On Turrent Blueprint");
        tasks[1].SetTask("Place atleast 2 Turrent on map");
        tasks[2].SetTask("Destroy atleast 3 enemy");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Task1()
    {
        if (!tasks[0].isTaskComplete)
        {
            tasks[0].OnTaskComplete();
        }

    }

    public void Task2()
    {
        turrentOnMap++;
        if (!tasks[1].isTaskComplete && turrentOnMap>=2)
        {
            tasks[1].OnTaskComplete();
        }

    }

    public void Task3()
    {
        enemyKill++;
        if (!tasks[2].isTaskComplete && enemyKill>=3)
        {
            tasks[2].OnTaskComplete();
        }

    }

}
