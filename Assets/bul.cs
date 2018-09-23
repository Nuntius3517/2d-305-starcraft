using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bul : MonoBehaviour {
    public GameObject soldier;
    public GameObject castle;

    // Use this for initialization
    void Start () {
        gameObject.GetComponent<Button>().onClick.AddListener(clickone);
    }

    // Update is called once per frame
    void Update () {

    }
    public void clickone() {
        float ran1 = Random.Range(-10.0f, 10.0f);
        float ran2 = Random.Range(-10.0f, 10.0f);

        Instantiate (soldier,castle.transform.position+new Vector3(ran1,ran2,0),Quaternion.identity );
    }
}