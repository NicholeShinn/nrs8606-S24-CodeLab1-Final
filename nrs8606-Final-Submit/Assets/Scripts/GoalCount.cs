using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GoalCount : MonoBehaviour
{
    public static int titleGoal;//static so it's always the same integer no matter the instances

    private void Update()
    {
        //Debug.Log(titleGoal);

        //when title goal reaches count of 12 load next scene
        if(titleGoal == 12)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
