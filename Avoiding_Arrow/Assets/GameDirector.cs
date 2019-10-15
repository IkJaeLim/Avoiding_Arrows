using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    GameObject Hp;
    // Start is called before the first frame update
    void Start()
    {
        this.Hp = GameObject.Find("Hp");
    }

    // Update is called once per frame
    public void DecreaseHp()
    {
        this.Hp.GetComponent<Image>().fillAmount -=0.25f;
        if(this.Hp.GetComponent<Image>().fillAmount == 0)
            SceneManager.LoadScene("GameOver");
    }
}
