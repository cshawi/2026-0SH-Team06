using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static GameManager Instance {get; private set;}

    //public int world {get; private set;}
    public int stage {get; private set;}
    public int lives {get; private set;}
    private void Awake()
    {
        if (Instance != null)
        {
            DestroyImmediate(gameObject);
        } else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    private void OnDestroy()
    {
        if (Instance == this)
        Instance = null;
    }

    private void Start()
    {
        NewGame();
    }
    private void NewGame()
    {
        lives = 3;
        LoadLevel(1);
    }

    private void LoadLevel(int stage)
    {
        //this.world = world;
        this.stage = stage;

        SceneManager.LoadScene("stage");

        switch (stage)
        {
            case 1: SceneManager.LoadScene("Village"); break;
            case 2: SceneManager.LoadScene("Chateau"); break;
            case 3: SceneManager.LoadScene("Lune"); break;
            default: SceneManager.LoadScene("TestingRoom"); break;
        }

    }

    public void NextLevel()
    {
        LoadLevel(stage + 1);
    }

    private void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
}
