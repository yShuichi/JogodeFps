using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ControladorJogo : MonoBehaviour
{
    
    public bool JogoON;
    public GameObject TelaInicial;
    public GameObject armaPlayer;
    public GameObject AmmoCanvas;
    public GameObject PlayerUICanvas;
    public GameObject cameraHolder;
    public GameObject playerPrefab;
    public PlayerMovement player;
    public Image frontHealth;
    public Image backHealth;
    private Vector3 playerSpawnPoint = new Vector3(338, 21, 370);


    public int enemiesAlive = 0;

    public TextMeshProUGUI waveText;
    public int wave = 0;

    public GameObject[] spawnPoints;

    public GameObject[] enemiesPrefabs;
    public GameObject[] enemiesSpawned;

    //public GameObject enemySoldierPrefab;
    //public GameObject enemyRobotSoldierPrefab;
    

    void Start()
    {
        JogoON = false;
        

    }

    
    void Update()
    {

        if (enemiesAlive == 0 && JogoON) {

            wave++;
            NextWave(wave);
            waveText.text = "Wave: " + wave.ToString();

        }
        
    }

    public void NextWave(int wave) {


        for (int i = 0;i < wave; i++) {

            for (int y = 0;y < 2; y++) {

                GameObject spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];

                Instantiate(enemiesPrefabs[Random.Range(0, enemiesPrefabs.Length)], spawnPoint.transform.position, Quaternion.identity);

                enemiesAlive++;

            }
            
        }

    }


    public void Iniciar()
    {

        JogoON = true;
        TelaInicial.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        armaPlayer.SetActive(true);
        AmmoCanvas.SetActive(true);
        PlayerUICanvas.SetActive(true);
        //Instantiate(playerPrefab, playerSpawnPoint, Quaternion.identity);

    }

    public void Reiniciar() {


        JogoON = false;
        AmmoCanvas.SetActive(false);
        PlayerUICanvas.SetActive(false);
        TelaInicial.SetActive(true);
        cameraHolder.transform.position = new Vector3(608, 190, 0);
        cameraHolder.transform.rotation = Quaternion.Euler(40, -14, 0);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        player.health = player.maxHealth;
        wave = 0;
        enemiesAlive = 0;
        playerPrefab.transform.position = playerSpawnPoint;

        enemiesSpawned = GameObject.FindGameObjectsWithTag("Enemy");
        frontHealth.fillAmount = 1;
        backHealth.fillAmount = 1;


        foreach(GameObject go in enemiesSpawned) {

            Destroy(go);

        }

    }

    public void Sair() {

        Application.Quit();

    }
    
}
