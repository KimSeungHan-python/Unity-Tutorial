using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
public class DifficultyButton : MonoBehaviour
{
    private Button button;

    private GameManager5 gameManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        button = GetComponent<Button>();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager5>();

        button.onClick.AddListener(SetDifficulty);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetDifficulty()
    {
        if (gameObject.name == "EasyButton")
        {
            gameManager.spawnRate = 1.5f;
        }
        else if (gameObject.name == "MediumButton")
        {
            gameManager.spawnRate = 1.0f;
        }
        else if (gameObject.name == "HardButton")
        {
            gameManager.spawnRate = 0.5f;
        }
        gameManager.StartGame();
    }
}
