using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{
    void Start() => time = timerTime;

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        if (time < 0)
        {
            SceneManager.LoadScene("Level_1");
        }
        currentText.text = "Time: " + time.ToString();
    }
    public float timerTime = 100f;

    private float time;
    public Text currentText;
}
