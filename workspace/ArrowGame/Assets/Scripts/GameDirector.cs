using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
public class GameDirector : MonoBehaviour
{

    public Player player; 
    public Generator generator; 
    static float time = 0;
    public TextMeshProUGUI TextHP;
    public TextMeshProUGUI TextTime;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
    }

    void Awake(){
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (player.HP >= 0){
            time += Time.deltaTime;
            this.TextHP.GetComponent<TextMeshProUGUI>().text = "HP : " + player.HP.ToString(); 
            this.TextTime.GetComponent<TextMeshProUGUI>().text = "Score : " + (int) time; 
            this.generator.arrowSpeed *= 1.03f;
        }
        else{
            if (!generator.stop){
                generator.stop = true;
                SceneManager.LoadScene("END", LoadSceneMode.Additive);
            }
        }
        
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
        else if (Input.GetKey(KeyCode.R)){
            SceneManager.LoadScene("Scene1", LoadSceneMode.Single);

        }
    
    }
}
