using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    private NavMeshAgent navMeshAgent;
    private Transform playerTransform;
    private int live;
    public TMP_Text liveTex;

    // Start is called before the first frame update
    void Start()
    {
        live = 3;
        navMeshAgent = GetComponent<NavMeshAgent>();
		playerTransform = FindAnyObjectByType<Player>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        navMeshAgent.destination = playerTransform.position;

        if (live == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    private void OnCollisionEnter(Collision collision) {
        if(collision.transform.CompareTag("Player")){
            live--;
            liveTex.text = live.ToString();

        }
    }
}
