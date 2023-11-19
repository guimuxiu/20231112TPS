using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.VirtualTexturing;
//UI•”•i
using UnityEngine.UI;


public partial class GM01 : MonoBehaviour
{



    #region Scean000
    public void ModeBTN01()
    {
        GetComponent<AudioSource>().PlayOneShot(SE[1]);

        BattleMode = 1;
    }

    public void ModeBTN03()
    {
        GetComponent<AudioSource>().PlayOneShot(SE[1]);

        BattleMode = 3;

    }
    #endregion Scean000

    #region Scene001

    public void BTN001Pla01Mon01()
    {
        GetComponent<AudioSource>().PlayOneShot(SE[1]);
        MonSet = 0010101;
    }

    public void BTN001Pla01Mon02()
    {
        GetComponent<AudioSource>().PlayOneShot(SE[1]);
        MonSet = 0010102;
    }

    public void BTN001Pla01Mon03()
    {
        GetComponent<AudioSource>().PlayOneShot(SE[1]);
        MonSet = 0010103;
    }
    public void BTN001Pla01Mon04()
    {
        GetComponent<AudioSource>().PlayOneShot(SE[1]);
        MonSet = 0010104;
    }
    public void BTN001Pla01Mon05()
    {
        GetComponent<AudioSource>().PlayOneShot(SE[1]);
        MonSet = 0010105;
    }
    public void BTN001Pla01Mon06()
    {
        GetComponent<AudioSource>().PlayOneShot(SE[1]);
        MonSet = 0010106;
    }
    public void BTN001Pla02Mon01()
    {
        GetComponent<AudioSource>().PlayOneShot(SE[1]);
        MonSet = 0010201;
    }

    public void BTN001Pla02Mon02()
    {
        GetComponent<AudioSource>().PlayOneShot(SE[1]);
        MonSet = 0010202;
    }

    public void BTN001Pla02Mon03()
    {
        GetComponent<AudioSource>().PlayOneShot(SE[1]);
        MonSet = 0010203;
    }
    public void BTN001Pla02Mon04()
    {
        GetComponent<AudioSource>().PlayOneShot(SE[1]);
        MonSet = 0010204;
    }
    public void BTN001Pla02Mon05()
    {
        GetComponent<AudioSource>().PlayOneShot(SE[1]);
        MonSet = 0010205;
    }
    public void BTN001Pla02Mon06()
    {
        GetComponent<AudioSource>().PlayOneShot(SE[1]);
        MonSet = 0010206;
    }
    public void BTN001Next()
    {
        GetComponent<AudioSource>().PlayOneShot(SE[1]);
        MonSet = 1;
    }
    public void BTN001Return()
    {
        GetComponent<AudioSource>().PlayOneShot(SE[1]);
        MonSet = 2;
    }






    #endregion Scene001
}
