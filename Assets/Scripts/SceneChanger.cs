using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public static class Variables
    {
        public static Material CurrentClothes { get; set; }
    }

    public void ChangeScene(string sceneName)
    {
        Variables.CurrentClothes = GetComponent<Renderer>().material;
        SceneManager.LoadScene(sceneName);
    }

    // Start is called before the first frame update
    void Start()
    {
        if (Variables.CurrentClothes != null)
        {
            GetComponent<Renderer>().material = Variables.CurrentClothes;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
