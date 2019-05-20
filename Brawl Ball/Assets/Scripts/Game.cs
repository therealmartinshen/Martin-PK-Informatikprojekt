using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public bool isControl = false;
    GameObject[] player;
    private void Start()
    {
        player = GameObject.FindGameObjectsWithTag("Player");
        Invoke("GameStart" , 3);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
        }

        foreach (GameObject i in player)
        {
            if(i.transform.position.y < -5)
            {
                Scene scene = SceneManager.GetActiveScene();
                SceneManager.LoadScene(scene.name);
            }
        }
    }

    IEnumerator GameStart()
    {
        yield return new WaitForSeconds(1);
        yield return new WaitForSeconds(1);
        yield return new WaitForSeconds(1);
        isControl = true;
    }
}
