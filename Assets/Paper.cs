using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Paper : MonoBehaviour
{
    [SerializeField] private List<Mesh> PaperList = new List<Mesh>();
    [SerializeField] int crumpleIndex;

    private MeshFilter mf;
    
    // Start is called before the first frame update
    void Start()
    {
        mf = GetComponent<MeshFilter>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    
    
    public void CrumplePaper()
    {
        crumpleIndex++;
        if(crumpleIndex < PaperList.Count)
            mf.mesh = PaperList[crumpleIndex];
    }
    
    
}
