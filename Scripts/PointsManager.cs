using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PointsManager : MonoBehaviour
{
    public static int points;

    public static int maxPoints;

    public int totalPoints = 0;

    public Text canvasText;

    private string tempText;

    // Start is called before the first frame update
    void Start()
    {
        points = 0;
        maxPoints = totalPoints;
        tempText = canvasText.text;
    }

    // Update is called once per frame
    void Update()
    {
        canvasText.text = tempText + points.ToString();
    }

    public static void UpdatePoints(int somaPonto)
    {
        points += somaPonto;
    }
}
