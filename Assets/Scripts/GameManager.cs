using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public TMP_Text collectiblesNumbersText;
    public TMP_Text totalCollectiblesNumbersText;

    private int collectiblesNumber;
    private int totalcollectiblesNumber;

    // Start is called before the first frame update
    void Start()
    {
        totalcollectiblesNumber = transform.childCount;
        totalCollectiblesNumbersText.text = totalcollectiblesNumber.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.childCount <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    public void AddCollectible()
    {
        collectiblesNumber++;
        collectiblesNumbersText.text = collectiblesNumber.ToString();
    }
}
