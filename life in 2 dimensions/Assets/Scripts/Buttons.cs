using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//****

public class Buttons : MonoBehaviour
{
    

    public void AloadTitle() {
        SceneManager.LoadScene("Title"); }

    // public void Aintro(){
    //     SceneManager.LoadScene("intro"); }

    public void Aintro(){
        SceneManager.LoadScene("Intro"); }
        
    public void Astart(){
        SceneManager.LoadScene("MainScene"); }

    
    public void Alose(){
        SceneManager.LoadScene("EndingLost"); }

    public void Awin(){
        SceneManager.LoadScene("EndingWin"); }

    public void Acredit(){
        SceneManager.LoadScene("credit"); }



}
