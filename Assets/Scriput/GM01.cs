using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;

//UI部品
using UnityEngine.UI;

public partial class GM01 : MonoBehaviour
{
    #region ◎オブジェクト等の定義

    //シーン番号
    public string SceneNumber = "000-000";

    //汎用タイマー
    public float timeCounter = 0.0f;

    //UI シーン番号の表示
    public GameObject UISceanNumber;

    //SE
    public AudioClip[] SE = new AudioClip[10];

    //ボタンの定義
    public GameObject[] Btn000 = new GameObject[4];
    public GameObject[] Btn001 = new GameObject[15];

    //バトルモード　シングルorトリプル 
    public int BattleMode = 0;

    //構築するポケモン
    public int MonSet = 0;


    //シーンフォルダ
    public GameObject[] SceneFolder = new GameObject[30];




    #endregion ◎オブジェクト等の定義

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //タイマー
        timeCounter += Time.deltaTime;

        //シーン番号を表示する
        UISceanNumber.GetComponent<Text>().text = "" + SceneNumber;


        if (SceneNumber == "000-000")
        {
            if (Input.GetMouseButtonDown(0))
            {
                //クリックしたらボタンを表示する
                Btn000[1].SetActive(true);
                Btn000[3].SetActive(true);



                //タイマーリセット
                timeCounter = 0.0f;

                //シーン変更
                SceneNumber = "000-001";
            }
        }
        else if (SceneNumber == "000-001")
        {

            if (BattleMode == 1)
            {
                SceneNumber = "001-100";

                //Btn000[1].SetActive(false);
                //Btn000[3].SetActive(false);
                //TextSign[01].SetActive(true);
                //for (int i = 1; i < 15; i++)
                //{ Btn001[i].SetActive(true); }


                SceneFolder[00].SetActive(false);
                SceneFolder[01].SetActive(true);


            }
            else if (BattleMode == 3)
            {
                SceneNumber = "001-300";
                SceneFolder[00].SetActive(false);
                SceneFolder[01].SetActive(true);
            }
        }
        else if (SceneNumber == "001-100")
        {
            if (MonSet == 0010101)
            {
                SceneNumber = "002-111";

                SceneFolder[01].SetActive(false);
                SceneFolder[02].SetActive(true);



            }
            else if (MonSet == 0010102)
            {
                SceneNumber = "002-112";
            }
            else if (MonSet == 0010103)
            {
                SceneNumber = "002-113";
            }
            else if (MonSet == 0010104)
            {
                SceneNumber = "002-114";
            }
            else if (MonSet == 0010105)
            {
                SceneNumber = "002-115";
            }
            else if (MonSet == 0010106)
            {
                SceneNumber = "002-116";
            }
            if (MonSet == 0010201)
            {
                SceneNumber = "002-121";
            }
            else if (MonSet == 0010202)
            {
                SceneNumber = "002-122";
            }
            else if (MonSet == 0010203)
            {
                SceneNumber = "002-123";
            }
            else if (MonSet == 0010204)
            {
                SceneNumber = "002-124";
            }
            else if (MonSet == 0010205)
            {
                SceneNumber = "002-125";
            }
            else if (MonSet == 0010206)
            {
                SceneNumber = "002-126";
            }
            else if (MonSet == 1)
            {
                SceneNumber = "003-001";
            }
            else if (MonSet == 2)
            {
                SceneNumber = "001-100";
                MonSet = 0;
                //もろもろをリセットする必要あり
            }

        }

        else if (SceneNumber == "001-300")
        {

        }



    }

}
