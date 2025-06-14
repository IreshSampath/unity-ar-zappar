using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContentManager : MonoBehaviour
{
    [SerializeField] List<GameObject> _mustaches;
    [SerializeField] List<GameObject> _beards;

     // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeMustaches(int index)
    {

        foreach(GameObject mustache in _mustaches)
        {
            mustache.SetActive(false);
        }
        if (index >= 0 && index < _mustaches.Count)
        {
            _mustaches[index].SetActive(true);
        }
        ChangeBeards(index);
    } 

    public void ChangeBeards(int index)
    {
        foreach(GameObject beard in _beards)
        {
            beard.SetActive(false);
        }
        if (index >= 0 && index < _beards.Count)
        {
            _beards[index].SetActive(true);
        }
    }
}
