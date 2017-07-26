using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SensesReviewSenseButton : MonoBehaviour {
    SensesReviewSenseItem item;

    private void Start() {
        item = FindObjectOfType<SensesReviewSenseItem>();
    }
    public void Touch() {
        for (int i = 0; i < item.touchImages.Length; i++) {
            if (item.touchImages[i] == )
        }
    }
    public void Smell() {

    }
    public void Hear() {

    }
    public void Taste() {

    }
    public void See() {

    }
}
