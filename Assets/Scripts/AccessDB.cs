using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AccessDB : MonoBehaviour
{

    string url = "http://localhost:81/updateScore.php";

    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Start()
    {
        
        WWW www = new WWW(url);
        yield return www;
        string result = www.text;
        print("data receieved" + result);
        GameObject.Find("high_scores").GetComponent<Text>().text = result;
    }
}
