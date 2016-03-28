using UnityEngine;
using System.Collections;

public class BookScript : MonoBehaviour {

    public Animator anim;
    public int bookNumber;
    public BookControl bookController;

	void Start () {
        if (!anim)
            anim = GetComponent<Animator>();
	}

    public void PutAway()
    {
        anim.SetBool("out", false);
    }

    public void TakeOut()
    {
        anim.SetBool("out", true);
    }

    public void Clicked()
    {
        
        bookController.ChooseBook(bookNumber);
    }
}
