using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

	public Text text;
	private enum States {start, start2, idle, idleWA, meditate, fletching, archeryNo, archery, huntingNo, hunting, leaving, end};
	private States myState;

	void Start () {
		myState = States.start;
	}

	void Update () {
		if 		(myState == States.start)				{start ();}
		else if (myState == States.start2)				{start2 ();}
		else if (myState == States.idle)				{idle ();}
		else if (myState == States.idleWA)				{idleWA ();}
		else if (myState == States.meditate)			{meditate ();}
		else if (myState == States.fletching)			{fletching ();}
		else if (myState == States.archeryNo)			{archeryNo ();}
		else if (myState == States.archery)				{archery ();}
		else if (myState == States.huntingNo)			{huntingNo ();}
		else if (myState == States.hunting)				{hunting ();}
		else if (myState == States.leaving)				{leaving ();}
		else if (myState == States.end)					{end ();}
	}

	#region state handler methods

	void start(){
		text.text = "...It has been 133 years...\n\n";
		if (Input.GetKeyDown(KeyCode.Space))			{myState = States.start2;}
	}	
	void start2(){
		text.text = "I've guarded this sacred grove for 133 years...\n\n" +
					"...waiting...\n" +
					"...watching...\n" +
					"...bored...";					
		if (Input.GetKeyDown(KeyCode.Space))			{myState = States.idle;}
	}
	void idle(){
		text.text = "What should I do today?\n\n" +
		"(M)editate\n" +
		"(F)letching\n" +
		"(A)rchery\n" +
		"(H)unting\n";

		if 		(Input.GetKeyDown(KeyCode.M))			{myState = States.meditate;}
		else if (Input.GetKeyDown(KeyCode.F))			{myState = States.fletching;}
		else if (Input.GetKeyDown(KeyCode.A))			{myState = States.archeryNo;}
		else if (Input.GetKeyDown(KeyCode.H))			{myState = States.huntingNo;}
		else if (Input.GetKeyDown(KeyCode.L))			{myState = States.leaving;}
	}	
	void idleWA(){
		text.text = "What should I do today?\n\n" +
			"(M)editate\n" +
			"(F)letching\n" +
			"(A)rchery\n" +
			"(H)unting\n";

		if 		(Input.GetKeyDown(KeyCode.M))			{myState = States.meditate;}
		else if (Input.GetKeyDown(KeyCode.F))			{myState = States.fletching;}
		else if (Input.GetKeyDown(KeyCode.A))			{myState = States.archery;}
		else if (Input.GetKeyDown(KeyCode.H))			{myState = States.hunting;}
		else if (Input.GetKeyDown(KeyCode.L))			{myState = States.leaving;}
	}
	void meditate(){
		text.text = "I spend the whole day meditating on this place, the stars, life, and solitude\n\n" +
					"...I have meditated on these thoughts for decades. I feel restless. There must be some other option...";

		if (Input.GetKeyDown(KeyCode.Space))			{myState = States.idle;}
	}
	void fletching(){
		text.text = "I spend the whole day fletching arrows.  a century ago, I would make as many arrows as possible. Now I only make a few but each is a work of art\n\n" +
					"...of course theres no one to admire them. Oh well, i'll use them soon enough...";

		if (Input.GetKeyDown(KeyCode.Space))			{myState = States.idleWA;}
	}
	void archeryNo(){
		text.text = "I need to make some arrows before I can practice my archery";

		if (Input.GetKeyDown(KeyCode.Space))			{myState = States.idle;}
	}
	void archery(){
		text.text = "I spend the whole day shooting arrows at targets I've set up around the mirrorpool. I've honed my archery to a peak and not a single arrow goes amiss\n\n" +
					"...Though at this point I've memorized where each target is and could hit them with my eyes closed. I'll have to move them again soon...";

		if (Input.GetKeyDown(KeyCode.Space))			{myState = States.idle;}
	}
	void huntingNo(){
		text.text = "I need to make some arrows before I can go hunting";

		if (Input.GetKeyDown(KeyCode.Space))			{myState = States.idle;}
	}
	void hunting(){
		text.text = "I spend the whole day out hunting. I know all the animals in this grove, I know which to hunt and where to find them\n\n" +
					"...They used to be a bit more wary of me, but now I think they see me in the same way as a tree. ageless and unmoving...";

		if (Input.GetKeyDown(KeyCode.Space))			{myState = States.idle;}
	}
	void leaving(){
		text.text = "I've realized there is life outside. I cannot sit idly any longer. I cannot protect the grove without knowing what lies beyond. I cannot admire it when it is all I've ever known\n\n" +
					"I will venture out. I will find myself. I will face the threats of the world. And I will return.";

		if (Input.GetKeyDown(KeyCode.Space))			{myState = States.end;}
	}
	void end(){
		text.text = "Play again?\n\n" +
					"Y/N";

		if 		(Input.GetKeyDown(KeyCode.Y))			{myState = States.start;}
		else if (Input.GetKeyDown(KeyCode.N))			{Application.Quit ();}
	}

	#endregion
}
