using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Puzzle2ChemSystem : MonoBehaviour {

    [SerializeField]
    private ChemType[] allChemTypes;

    [HideInInspector]
    public Dictionary<int, P2Chem> allChems = new Dictionary<int, P2Chem>();

    private void Awake(){
        for (int i = 0; i < allChemTypes.Length; i++) {
            ChemType newChemType = allChemTypes[i];
            P2Chem newChem = new P2Chem(i, newChemType.chemName, newChemType.chemMat);
            allChems[i] = newChem;
            Debug.Log("Chem added to dictionary" + allChems[i].chemName);
        }
    }
}

public class P2Chem {
    public int chemID;
    public string chemName;
    public Material chemMaterial;

    public P2Chem(int chemID, string name, Material mat) {
        this.chemID = chemID;
        this.chemName = name;
        this.chemMaterial = mat;
    }
}

[Serializable]
public struct ChemType {
    public string chemName;
    public Material chemMat;
}