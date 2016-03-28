using UnityEngine;
using System.Collections;

public class BookControl : MonoBehaviour {

    public int bookChosen = -1;
    public BookScript[] books;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ChooseBook(int bookBeingChosen)
    {
        if (bookChosen == bookBeingChosen)
        {
            books[bookBeingChosen].PutAway();
            bookChosen = -1;
        }
        else
        {
            for (int i = 0; i < books.Length; i++)
                if (i != bookBeingChosen)
                    books[i].PutAway();
            bookChosen = bookBeingChosen;
            books[bookChosen].TakeOut();
        }
        
    }
}
