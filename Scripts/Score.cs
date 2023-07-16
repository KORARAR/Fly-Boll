using UnityEngine;

public class Score : MonoBehaviour
{
    public int scor { get; private set; }
    public int ScorRec { get; private set; }
    [SerializeField] private ScoreText scoreText;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "St")
        {
            scor++;
            
            scoreText.UpdateScoreText(scor);
            if(ScorRec < scor)
            {
                ScorRec = scor;
                PlayerPrefs.SetInt("Scor", ScorRec);
                scoreText.UpdateScoreTextRec(ScorRec);
            }
        }
    }

    private void Start() 
    {
        ScorRec = PlayerPrefs.GetInt("Scor", ScorRec);

        scoreText.UpdateScoreText(0);
        scoreText.UpdateScoreTextRec(ScorRec);
    }
}
