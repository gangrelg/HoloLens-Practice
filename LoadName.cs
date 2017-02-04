using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadName : MonoBehaviour {

    // Use this for initialization


    public Text mystring;
    public string[] items;

    // Use this for initialization
    IEnumerator Start()
    {
        mystring = mystring.GetComponent<Text>();
        WWW itemsData = new WWW("http://192.168.100.110:8080/hellounity/helloworld.php");
        yield return itemsData;
        string itemsDataString = itemsData.text;
        print(itemsDataString);
        items = itemsDataString.Split(';');
        mystring.text = "Mi nombre es: " + GetDataValue(items[0], "Nombre:");
    }

    //Metodo Separar tuplas por operador logico
    string GetDataValue(string data, string index)
    {
        string value = data.Substring(data.IndexOf(index) + index.Length);
        if (value.Contains("|")) value = value.Remove(value.IndexOf("|"));
        return value;
    }


    // Update is called once per frame
    void Update () {
		
	}
}
