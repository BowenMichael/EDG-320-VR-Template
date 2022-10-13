using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PrinterManager : MonoBehaviour
{
    [SerializeField] private GameObject paper;
    private XRBaseInteractable Interactable;

    

    private void Start()
    {
        Interactable = GetComponent<XRBaseInteractable>();
        Interactable.selectEntered.AddListener(GrabPrinter);
    }

    public void GrabPrinter(SelectEnterEventArgs onGrab)
    {
        GameObject newPaper = Instantiate(paper, onGrab.interactorObject.transform.position, Quaternion.identity);
        onGrab.interactorObject.transform.gameObject.GetComponent<XRBaseInteractor>().attachTransform = newPaper.transform;
    }
}
