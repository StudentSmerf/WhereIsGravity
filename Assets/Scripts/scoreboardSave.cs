using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
namespace Score
{
    [Serializable]
    public class ScoreBoardEntry{
        public string scoreTime;
        public float scoreNumberOfEnemies;
        public int place;
        public string win;
    }


    


    [Serializable]
    public class scoreboardSave : MonoBehaviour
    {
        ScoreBoardEntry scoreboardentry = new ScoreBoardEntry();

        public string time;
        public int seconds;
        public int minutes;
        public float numberOfEnemies;
        
        
        
        [SerializeField] private TextMeshProUGUI entryTimeText = null;
        [SerializeField] private TextMeshProUGUI entryEnemiesText = null;
        [SerializeField] private TextMeshProUGUI entryPlaceText = null;
        [SerializeField] private TextMeshProUGUI entryWinText = null;
        [SerializeField] private Transform highscoresHolderTransform = null;
        [SerializeField] private GameObject scoreboardEntryObj = null;

        
        [SerializeField] public List<ScoreBoardEntry> ScoreList = new List<ScoreBoardEntry>(6);

        public void Start()
        {

            //ustawianie zmiennych

            minutes = PlayerPrefs.GetInt("minutes");
            seconds = PlayerPrefs.GetInt("seconds");
            numberOfEnemies = PlayerPrefs.GetFloat("enemiesnum");
            time = minutes + " : " + seconds;
            scoreboardentry.win = PlayerPrefs.GetString("win");
            scoreboardentry.scoreTime = time;
            scoreboardentry.scoreNumberOfEnemies = numberOfEnemies;
            scoreboardentry.place = 0;
            
            ScoreList.Add(scoreboardentry);

            
            


            for (int i = 0; i < 5; i++)
            {
                ScoreList.Add(JsonUtility.FromJson<ScoreBoardEntry>(PlayerPrefs.GetString("Scoreboard" + i)));
                
            }

            


            
            for (int i = 0; i < ScoreList.Count; i++)
            {
                PlayerPrefs.SetString("Scoreboard" + i, JsonUtility.ToJson(ScoreList[i]));
            }
            

            
            

            
            //inicjowaie wierszy

            
            
            for(int i = 0; i < ScoreList.Count; i++){
                
                scoreboardentry = ScoreList[i];
                

                
                    
               

                scoreboardentry.place = i + 1;
                entryTimeText.text = scoreboardentry.scoreTime.ToString();
                entryEnemiesText.text = scoreboardentry.scoreNumberOfEnemies.ToString();
                entryWinText.text = scoreboardentry.win.ToString();
                entryPlaceText.text = scoreboardentry.place.ToString();
                
                Instantiate(scoreboardEntryObj, highscoresHolderTransform, false); 
            }
           

            
            scoreboardEntryObj.SetActive(false);
            
        }
        public void DontDestroyOnLoad(){
            
        }


    }
}

