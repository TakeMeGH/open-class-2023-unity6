using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    public static GameManager Singleton { get; private set; }    
    private int _totalSnowman = 3;
    private int _totalPlayerSnowman = 0;
    [SerializeField] Transform[] _snowmanLocations;
    
    public void Awake()
    {
        if (Singleton != null && Singleton != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Singleton = this;
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        SpawnSnowman();
        UpdateSnowmanCounter();
    }
    
    private void SpawnSnowman()
    {
        // TODO : Implementasikan fungsi untuk spawn snowman
    }

    public void playerTakeSnowman()
    {
        // TODO : Implementasikan fungsi yang dipanggil ketika player berhasil mengammbil sebuah snowman
    }

    public void UpdateSnowmanCounter()
    {
        // TODO : Implementasikan fungsi yang mengupdate UI tentang banyaknya snowman yang sudah dikoleksi player
    }

    public void GameWin()
    {
        // TODO : Implementasikan fungsi yang dipanggil ketika player menyelesaikan permainan
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    


}
