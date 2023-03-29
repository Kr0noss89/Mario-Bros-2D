using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.SceneManagement;

public class GameManager : MonoBehaviour
{

    public bool isGameOver;

    public bool canShoot;

    public float powerUpDuration = 5;

    public float powerUpTimer = 0;

    public Text coinText;
    
    int coins;


    void update()
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

   public void AddCoin()
   {
         coins++;
         coinText.text = coins.ToString();
   }

   void ShootPowerUp()
   {
    if(canShoot)
    {
        if(powerUpTimer <= powerUpDuration)
        {
            powerUpTimer += Time.deltaTime;
        }
        else
        {
            canShoot = false;
            powerUpTimer = 0;
        }
    }
   }
}


