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

    public void Atutorial(){
        SceneManager.LoadScene("Tutorial"); }
        
    public void Astart(){
        SceneManager.LoadScene("Game"); }

    
    public void Alose(){
        SceneManager.LoadScene("EndingLost"); }

    public void Awin(){
        SceneManager.LoadScene("EndingWin"); }

    public void Acredit(){
        SceneManager.LoadScene("credit"); }



}
