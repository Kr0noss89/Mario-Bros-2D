using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.SceneManagement;

public class GameManager : MonoBehaviour
{

    public bool isGameOver;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void GameOver()
    {
        isGameOver = true;

        //Lamar funcion de forma normal
        //LoadScene();

        //Invocamos la funcion despues de 1.5 segundos
        //Invoke("LoadScene", 2.5f);

        StartCoroutine("LoadScene");
    }


   // void LoadScene()
   //{
       // SceneManager.LoadScene(1);
   // }

   IEnumerator LoadScene()
   {
       //Esto es para la corutina durante 2.5 segundos
       yield return new WaitForSeconds(2.5f);

       SceneManager.LoadScene(0);    
   }
}


