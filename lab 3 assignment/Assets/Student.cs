using UnityEngine;
using UnityEditor;
using System;

public class Student : MonoBehaviour
{
    [Header("Course Details")]

    public string courseName = "DIG 4714C"; 
    public int numMods = 10;
    public int numReadMats = 20;
    public int numQuiz = 5;
    public int numAssignments = 10;
    public bool teacherAbility = true;

    private const double modWeight = 0.15;
    private const double readWeight = 0.30;
    private const double quizWeight = 0.15; 
    private const double assignmentWeight = 0.30;
    private const double teacherExp = 0.10;

    void Start()
    {
        courseDifficultyCal();
    }



    public void courseDifficultyCal()
    {
        double diffScore = (numMods * modWeight) + (numReadMats * readWeight) +
                           (numQuiz * quizWeight) + (numAssignments * assignmentWeight) + (teacherAbility ? teacherExp : 0);
        
        diffScore = Math.Clamp(diffScore,1.0,10.0);

        Debug.Log($"{courseName} Difficulty Score: {diffScore}");
    }
}
