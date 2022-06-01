using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public int highscore;
    public string user;
    private Text highscoreText;

    private void Awake()
    {
        highscoreText = GetComponent<Text>();
    }

    private void Start()
    {
        LoadScore();
        highscoreText.text = "Best Score: " + user + " - " + highscore;
    }

    public void NewHighscore(int score)
    {
        highscore = score;
        user = UsernameHolder.Instance.username;
        highscoreText.text = "Best Score: " + user + " - " + highscore;
        SaveScore();
    }

    [System.Serializable]
    public class ScoreData
    {
        public int highscore;
        public string user;
    }

    public void SaveScore()
    {
        ScoreData data = new ScoreData();
        data.highscore = highscore;
        data.user = user;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);

    }

    public void LoadScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            ScoreData data = JsonUtility.FromJson<ScoreData>(json);

            highscore = data.highscore;
            user = data.user;
        }
    }
}
