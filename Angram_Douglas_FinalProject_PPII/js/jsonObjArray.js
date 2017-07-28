var questions = {"allQuestions": [
	{"question": "What record single was the first to go platinum?"},
	{"selections": {
		"A": "A. Disco Lady by Jonnie Taylor",
		"B": "B. Thriller by Michael Jackson",
		"C": "C. Smells Like Teen Spirit by Nirvana",
		"D": "D. Hey Jude by The Beatles"
	}},

	{"question": "What is the name of the brightest nebula?"},
	{"selections": {
		"A": "A. Mily Way",
		"B": "B. Aries",
		"C": "C. Orion",
		"D": "D. Sun"
	}},

	{"question": "Which person was not a member of the Rat Pack?"},
	{"selections": {
		"A": "A. Sammy Davis, Jr",
		"B": "B. Humphrey Bogart",
		"C": "C. Dean Martin",
		"D": "D. Frank Sinatra"
	}},

	{"question": "Which country is in Europe?"},
	{"selections": {
		"A": "A. Ukraine",
		"B": "B. Russia",
		"C": "C. Persia",
		"D": "D. India"
	}},

	{"question": "The edge of a black hole is called what?"},
	{"selections": {
		"A": "A. Quazar",
		"B": "B. Gravity",
		"C": "C. Pulsar",
		"D": "D. The Event Horizon"
	}},

	{"question": "What determines the atomic number of an element?"},
	{"selections": {
		"A": "A. The Number of Atoms",
		"B": "B. The Number of Electrons in Its Atom",
		"C": "C. The Number of Protons in Its Atom",
		"D": "D. The Nucleus in Its Atom"
	}},

	{"question": "In what year did Germany invade Poland?"},
	{"selections": {
		"A": "A. 1939",
		"B": "B. 1945",
		"C": "C. 1938",
		"D": "D. 1940"
	}},

	{"question": "What year was the rap song Rappers Delight released?"},
	{"selections": {
		"A": "A. 1978",
		"B": "B. 1980",
		"C": "C. 1981",
		"D": "D. 1979"
	}},

	{"question": "Who was a member of Nsync?"},
	{"selections": {
		"A": "A. Justin Timberlake",
		"B": "B. Britney Spears",
		"C": "C. Dave Grohl",
		"D": "D. Sting"
	}},

	{"question": "Where is the Mason-Dixon line?"},
	{"selections": {
		"A": "A. Florida and Georgia",
		"B": "B. New York and Canada",
		"C": "C. Maryland and Pennsylvania",
		"D": "D. Tennessee and Arkansas"
	}}
]};

	var score = 0;
	var total = 10;
	var formMessages11 = document.getElementById("form-messages11");

	/*QUESTION 1*/
	var w1h1 = document.getElementById("wrapper1").querySelector("h1");
	var formMessages1 = document.getElementById("form-messages1");
	var inputAQ1Label = document.getElementById("wrapper1").querySelector("form").querySelector("div:nth-child(1)").querySelector("label");
	var inputBQ1Label = document.getElementById("wrapper1").querySelector("form").querySelector("div:nth-child(2)").querySelector("label");
	var inputCQ1Label = document.getElementById("wrapper1").querySelector("form").querySelector("div:nth-child(3)").querySelector("label");
	var inputDQ1Label = document.getElementById("wrapper1").querySelector("form").querySelector("div:nth-child(4)").querySelector("label");
	var inputAQ1Input = document.getElementById("wrapper1").querySelector("form").querySelector("div:nth-child(1)").querySelector("input");
	var inputBQ1Input = document.getElementById("wrapper1").querySelector("form").querySelector("div:nth-child(2)").querySelector("input");
	var inputCQ1Input = document.getElementById("wrapper1").querySelector("form").querySelector("div:nth-child(3)").querySelector("input");
	var inputDQ1Input = document.getElementById("wrapper1").querySelector("form").querySelector("div:nth-child(4)").querySelector("input");

	w1h1.innerHTML = questions.allQuestions[0].question;
	inputAQ1Label.innerHTML = questions.allQuestions[1].selections.A;
	inputBQ1Label.innerHTML = questions.allQuestions[1].selections.B;
	inputCQ1Label.innerHTML = questions.allQuestions[1].selections.C;
	inputDQ1Label.innerHTML = questions.allQuestions[1].selections.D;

	for(var i = 1; i <= total; i++)
	{
	var questionOne = function()
	{
		if (inputAQ1Input.value === "" && inputBQ1Input.value === "" && inputCQ1Input.value === "" && inputDQ1Input.value === "")
		{
			alert("You must enter A, B, C or D for question 1!");
			return false;
		}

		if (inputAQ1Input.value == "A" || inputAQ1Input.value == "a")
		{
			formMessages1.innerHTML = "Correct";
			inputAQ1Input.value = "";
			inputBQ1Input.value = "";
			inputCQ1Input.value = "";
			inputDQ1Input.value = "";
			inputAQ1Input.disabled = true;
			inputBQ1Input.disabled = true;
			inputCQ1Input.disabled = true;
			inputDQ1Input.disabled = true;
			score++;
			formMessages11.innerHTML = "You got " + score + " out of " + total + ".";
			return false;
		}

		else
		{
			formMessages1.innerHTML = "Wrong";
			inputAQ1Input.value = "";
			inputBQ1Input.value = "";
			inputCQ1Input.value = "";
			inputDQ1Input.value = "";
			inputAQ1Input.disabled = true;
			inputBQ1Input.disabled = true;
			inputCQ1Input.disabled = true;
			inputDQ1Input.disabled = true;
			return false;
		}
	}
	//


	/*QUESTION 2*/
	var w2h2 = document.getElementById("wrapper2").querySelector("h1");
	var formMessages2 = document.getElementById("form-messages2");
	var inputAQ2Label = document.getElementById("wrapper2").querySelector("form").querySelector("div:nth-child(1)").querySelector("label");
	var inputBQ2Label = document.getElementById("wrapper2").querySelector("form").querySelector("div:nth-child(2)").querySelector("label");
	var inputCQ2Label = document.getElementById("wrapper2").querySelector("form").querySelector("div:nth-child(3)").querySelector("label");
	var inputDQ2Label = document.getElementById("wrapper2").querySelector("form").querySelector("div:nth-child(4)").querySelector("label");
	var inputAQ2Input = document.getElementById("wrapper2").querySelector("form").querySelector("div:nth-child(1)").querySelector("input");
	var inputBQ2Input = document.getElementById("wrapper2").querySelector("form").querySelector("div:nth-child(2)").querySelector("input");
	var inputCQ2Input = document.getElementById("wrapper2").querySelector("form").querySelector("div:nth-child(3)").querySelector("input");
	var inputDQ2Input = document.getElementById("wrapper2").querySelector("form").querySelector("div:nth-child(4)").querySelector("input");

	w2h2.innerHTML = questions.allQuestions[2].question;
	inputAQ2Label.innerHTML = questions.allQuestions[3].selections.A;
	inputBQ2Label.innerHTML = questions.allQuestions[3].selections.B;
	inputCQ2Label.innerHTML = questions.allQuestions[3].selections.C;
	inputDQ2Label.innerHTML = questions.allQuestions[3].selections.D;

	var questionTwo = function()
	{
		if (inputAQ2Input.value === "" && inputBQ2Input.value === "" && inputCQ2Input.value === "" && inputDQ2Input.value === "")
		{
			alert("You must enter A, B, C or D for question 2!");
			return false;
		}

		if (inputCQ2Input.value == "C" || inputCQ2Input.value == "c")
		{
			formMessages2.innerHTML = "Correct";
			inputAQ2Input.value = "";
			inputBQ2Input.value = "";
			inputCQ2Input.value = "";
			inputDQ2Input.value = "";
			inputAQ2Input.disabled = true;
			inputBQ2Input.disabled = true;
			inputCQ2Input.disabled = true;
			inputDQ2Input.disabled = true;
			score++;
			formMessages11.innerHTML = "You got " + score + " out of " + total + ".";
			return false;
		}

		else
		{
			formMessages2.innerHTML = "Wrong";
			inputAQ2Input.value = "";
			inputBQ2Input.value = "";
			inputCQ2Input.value = "";
			inputDQ2Input.value = "";
			inputAQ2Input.disabled = true;
			inputBQ2Input.disabled = true;
			inputCQ2Input.disabled = true;
			inputDQ2Input.disabled = true;
			return false;
		}
	}
	//


	/*QUESTION 3*/
	var w3h3 = document.getElementById("wrapper3").querySelector("h1");
	var formMessages3 = document.getElementById("form-messages3");
	var inputAQ3Label = document.getElementById("wrapper3").querySelector("form").querySelector("div:nth-child(1)").querySelector("label");
	var inputBQ3Label = document.getElementById("wrapper3").querySelector("form").querySelector("div:nth-child(2)").querySelector("label");
	var inputCQ3Label = document.getElementById("wrapper3").querySelector("form").querySelector("div:nth-child(3)").querySelector("label");
	var inputDQ3Label = document.getElementById("wrapper3").querySelector("form").querySelector("div:nth-child(4)").querySelector("label");
	var inputAQ3Input = document.getElementById("wrapper3").querySelector("form").querySelector("div:nth-child(1)").querySelector("input");
	var inputBQ3Input = document.getElementById("wrapper3").querySelector("form").querySelector("div:nth-child(2)").querySelector("input");
	var inputCQ3Input = document.getElementById("wrapper3").querySelector("form").querySelector("div:nth-child(3)").querySelector("input");
	var inputDQ3Input = document.getElementById("wrapper3").querySelector("form").querySelector("div:nth-child(4)").querySelector("input");

	w3h3.innerHTML = questions.allQuestions[4].question;
	inputAQ3Label.innerHTML = questions.allQuestions[5].selections.A;
	inputBQ3Label.innerHTML = questions.allQuestions[5].selections.B;
	inputCQ3Label.innerHTML = questions.allQuestions[5].selections.C;
	inputDQ3Label.innerHTML = questions.allQuestions[5].selections.D;

	var questionThree = function()
	{
		if (inputAQ3Input.value === "" && inputBQ3Input.value === "" && inputCQ3Input.value === "" && inputDQ3Input.value === "")
		{
			alert("You must enter A, B, C or D for question 3!");
			return false;
		}

		if (inputBQ3Input.value == "B" || inputBQ3Input.value == "b")
		{
			formMessages3.innerHTML = "Correct";
			inputAQ3Input.value = "";
			inputBQ3Input.value = "";
			inputCQ3Input.value = "";
			inputDQ3Input.value = "";
			inputAQ3Input.disabled = true;
			inputBQ3Input.disabled = true;
			inputCQ3Input.disabled = true;
			inputDQ3Input.disabled = true;
			score++;
			formMessages11.innerHTML = "You got " + score + " out of " + total + ".";
			return false;
		}

		else
		{
			formMessages3.innerHTML = "Wrong";
			inputAQ3Input.value = "";
			inputBQ3Input.value = "";
			inputCQ3Input.value = "";
			inputDQ3Input.value = "";
			inputAQ3Input.disabled = true;
			inputBQ3Input.disabled = true;
			inputCQ3Input.disabled = true;
			inputDQ3Input.disabled = true;
			return false;
		}
	}
	//


	/*QUESTION 4*/
	var w4h4 = document.getElementById("wrapper4").querySelector("h1");
	var formMessages4 = document.getElementById("form-messages4");
	var inputAQ4Label = document.getElementById("wrapper4").querySelector("form").querySelector("div:nth-child(1)").querySelector("label");
	var inputBQ4Label = document.getElementById("wrapper4").querySelector("form").querySelector("div:nth-child(2)").querySelector("label");
	var inputCQ4Label = document.getElementById("wrapper4").querySelector("form").querySelector("div:nth-child(3)").querySelector("label");
	var inputDQ4Label = document.getElementById("wrapper4").querySelector("form").querySelector("div:nth-child(4)").querySelector("label");
	var inputAQ4Input = document.getElementById("wrapper4").querySelector("form").querySelector("div:nth-child(1)").querySelector("input");
	var inputBQ4Input = document.getElementById("wrapper4").querySelector("form").querySelector("div:nth-child(2)").querySelector("input");
	var inputCQ4Input = document.getElementById("wrapper4").querySelector("form").querySelector("div:nth-child(3)").querySelector("input");
	var inputDQ4Input = document.getElementById("wrapper4").querySelector("form").querySelector("div:nth-child(4)").querySelector("input");

	w4h4.innerHTML = questions.allQuestions[6].question;
	inputAQ4Label.innerHTML = questions.allQuestions[7].selections.A;
	inputBQ4Label.innerHTML = questions.allQuestions[7].selections.B;
	inputCQ4Label.innerHTML = questions.allQuestions[7].selections.C;
	inputDQ4Label.innerHTML = questions.allQuestions[7].selections.D;

	var questionFour = function()
	{
		if (inputAQ4Input.value === "" && inputBQ4Input.value === "" && inputCQ4Input.value === "" && inputDQ4Input.value === "")
		{
			alert("You must enter A, B, C or D for question 4!");
			return false;
		}

		if (inputAQ4Input.value == "A" || inputAQ4Input.value == "a")
		{
			formMessages4.innerHTML = "Correct";
			inputAQ4Input.value = "";
			inputBQ4Input.value = "";
			inputCQ4Input.value = "";
			inputDQ4Input.value = "";
			inputAQ4Input.disabled = true;
			inputBQ4Input.disabled = true;
			inputCQ4Input.disabled = true;
			inputDQ4Input.disabled = true;
			score++;
			formMessages11.innerHTML = "You got " + score + " out of " + total + ".";
			return false;
		}

		else
		{
			formMessages4.innerHTML = "Wrong";
			inputAQ4Input.value = "";
			inputBQ4Input.value = "";
			inputCQ4Input.value = "";
			inputDQ4Input.value = "";
			inputAQ4Input.disabled = true;
			inputBQ4Input.disabled = true;
			inputCQ4Input.disabled = true;
			inputDQ4Input.disabled = true;
			return false;
		}
	}
	//


	/*QUESTION 5*/
	var w5h5 = document.getElementById("wrapper5").querySelector("h1");
	var formMessages5 = document.getElementById("form-messages5");
	var inputAQ5Label = document.getElementById("wrapper5").querySelector("form").querySelector("div:nth-child(1)").querySelector("label");
	var inputBQ5Label = document.getElementById("wrapper5").querySelector("form").querySelector("div:nth-child(2)").querySelector("label");
	var inputCQ5Label = document.getElementById("wrapper5").querySelector("form").querySelector("div:nth-child(3)").querySelector("label");
	var inputDQ5Label = document.getElementById("wrapper5").querySelector("form").querySelector("div:nth-child(4)").querySelector("label");
	var inputAQ5Input = document.getElementById("wrapper5").querySelector("form").querySelector("div:nth-child(1)").querySelector("input");
	var inputBQ5Input = document.getElementById("wrapper5").querySelector("form").querySelector("div:nth-child(2)").querySelector("input");
	var inputCQ5Input = document.getElementById("wrapper5").querySelector("form").querySelector("div:nth-child(3)").querySelector("input");
	var inputDQ5Input = document.getElementById("wrapper5").querySelector("form").querySelector("div:nth-child(4)").querySelector("input");

	w5h5.innerHTML = questions.allQuestions[8].question;
	inputAQ5Label.innerHTML = questions.allQuestions[9].selections.A;
	inputBQ5Label.innerHTML = questions.allQuestions[9].selections.B;
	inputCQ5Label.innerHTML = questions.allQuestions[9].selections.C;
	inputDQ5Label.innerHTML = questions.allQuestions[9].selections.D;

	var questionFive = function()
	{
		if (inputAQ5Input.value === "" && inputBQ5Input.value === "" && inputCQ5Input.value === "" && inputDQ5Input.value === "")
		{
			alert("You must enter A, B, C or D for question 5!");
			return false;
		}

		if (inputDQ5Input.value == "D" || inputDQ5Input.value == "d")
		{
			formMessages5.innerHTML = "Correct";
			inputAQ5Input.value = "";
			inputBQ5Input.value = "";
			inputCQ5Input.value = "";
			inputDQ5Input.value = "";
			inputAQ5Input.disabled = true;
			inputBQ5Input.disabled = true;
			inputCQ5Input.disabled = true;
			inputDQ5Input.disabled = true;
			score++;
			formMessages11.innerHTML = "You got " + score + " out of " + total + ".";
			return false;
		}

		else
		{
			formMessages5.innerHTML = "Wrong";
			inputAQ5Input.value = "";
			inputBQ5Input.value = "";
			inputCQ5Input.value = "";
			inputDQ5Input.value = "";
			inputAQ5Input.disabled = true;
			inputBQ5Input.disabled = true;
			inputCQ5Input.disabled = true;
			inputDQ5Input.disabled = true;
			return false;
		}
	}
	//


	/*QUESTION 6*/
	var w6h6 = document.getElementById("wrapper6").querySelector("h1");
	var formMessages6 = document.getElementById("form-messages6");
	var inputAQ6Label = document.getElementById("wrapper6").querySelector("form").querySelector("div:nth-child(1)").querySelector("label");
	var inputBQ6Label = document.getElementById("wrapper6").querySelector("form").querySelector("div:nth-child(2)").querySelector("label");
	var inputCQ6Label = document.getElementById("wrapper6").querySelector("form").querySelector("div:nth-child(3)").querySelector("label");
	var inputDQ6Label = document.getElementById("wrapper6").querySelector("form").querySelector("div:nth-child(4)").querySelector("label");
	var inputAQ6Input = document.getElementById("wrapper6").querySelector("form").querySelector("div:nth-child(1)").querySelector("input");
	var inputBQ6Input = document.getElementById("wrapper6").querySelector("form").querySelector("div:nth-child(2)").querySelector("input");
	var inputCQ6Input = document.getElementById("wrapper6").querySelector("form").querySelector("div:nth-child(3)").querySelector("input");
	var inputDQ6Input = document.getElementById("wrapper6").querySelector("form").querySelector("div:nth-child(4)").querySelector("input");

	w6h6.innerHTML = questions.allQuestions[10].question;
	inputAQ6Label.innerHTML = questions.allQuestions[11].selections.A;
	inputBQ6Label.innerHTML = questions.allQuestions[11].selections.B;
	inputCQ6Label.innerHTML = questions.allQuestions[11].selections.C;
	inputDQ6Label.innerHTML = questions.allQuestions[11].selections.D;

	var questionSix = function()
	{
		if (inputAQ6Input.value === "" && inputBQ6Input.value === "" && inputCQ6Input.value === "" && inputDQ6Input.value === "")
		{
			alert("You must enter A, B, C or D for question 6!");
			return false;
		}

		if (inputCQ6Input.value == "C" || inputCQ6Input.value == "c")
		{
			formMessages6.innerHTML = "Correct";
			inputAQ6Input.value = "";
			inputBQ6Input.value = "";
			inputCQ6Input.value = "";
			inputDQ6Input.value = "";
			inputAQ6Input.disabled = true;
			inputBQ6Input.disabled = true;
			inputCQ6Input.disabled = true;
			inputDQ6Input.disabled = true;
			score++;
			formMessages11.innerHTML = "You got " + score + " out of " + total + ".";
			return false;
		}

		else
		{
			formMessages6.innerHTML = "Wrong";
			inputAQ6Input.value = "";
			inputBQ6Input.value = "";
			inputCQ6Input.value = "";
			inputDQ6Input.value = "";
			inputAQ6Input.disabled = true;
			inputBQ6Input.disabled = true;
			inputCQ6Input.disabled = true;
			inputDQ6Input.disabled = true;
			return false;
		}
	}
	//


	/*QUESTION 7*/
	var w7h7 = document.getElementById("wrapper7").querySelector("h1");
	var formMessages7 = document.getElementById("form-messages7");
	var inputAQ7Label = document.getElementById("wrapper7").querySelector("form").querySelector("div:nth-child(1)").querySelector("label");
	var inputBQ7Label = document.getElementById("wrapper7").querySelector("form").querySelector("div:nth-child(2)").querySelector("label");
	var inputCQ7Label = document.getElementById("wrapper7").querySelector("form").querySelector("div:nth-child(3)").querySelector("label");
	var inputDQ7Label = document.getElementById("wrapper7").querySelector("form").querySelector("div:nth-child(4)").querySelector("label");
	var inputAQ7Input = document.getElementById("wrapper7").querySelector("form").querySelector("div:nth-child(1)").querySelector("input");
	var inputBQ7Input = document.getElementById("wrapper7").querySelector("form").querySelector("div:nth-child(2)").querySelector("input");
	var inputCQ7Input = document.getElementById("wrapper7").querySelector("form").querySelector("div:nth-child(3)").querySelector("input");
	var inputDQ7Input = document.getElementById("wrapper7").querySelector("form").querySelector("div:nth-child(4)").querySelector("input");

	w7h7.innerHTML = questions.allQuestions[12].question;
	inputAQ7Label.innerHTML = questions.allQuestions[13].selections.A;
	inputBQ7Label.innerHTML = questions.allQuestions[13].selections.B;
	inputCQ7Label.innerHTML = questions.allQuestions[13].selections.C;
	inputDQ7Label.innerHTML = questions.allQuestions[13].selections.D;

	var questionSeven = function()
	{
		if (inputAQ7Input.value === "" && inputBQ7Input.value === "" && inputCQ7Input.value === "" && inputDQ7Input.value === "")
		{
			alert("You must enter A, B, C or D for question 7!");
			return false;
		}

		if (inputAQ7Input.value == "A" || inputAQ7Input.value == "a")
		{
			formMessages7.innerHTML = "Correct";
			inputAQ7Input.value = "";
			inputBQ7Input.value = "";
			inputCQ7Input.value = "";
			inputDQ7Input.value = "";
			inputAQ7Input.disabled = true;
			inputBQ7Input.disabled = true;
			inputCQ7Input.disabled = true;
			inputDQ7Input.disabled = true;
			score++;
			formMessages11.innerHTML = "You got " + score + " out of " + total + ".";
			return false;
		}

		else
		{
			formMessages7.innerHTML = "Wrong";
			inputAQ7Input.value = "";
			inputBQ7Input.value = "";
			inputCQ7Input.value = "";
			inputDQ7Input.value = "";
			inputAQ7Input.disabled = true;
			inputBQ7Input.disabled = true;
			inputCQ7Input.disabled = true;
			inputDQ7Input.disabled = true;
			return false;
		}
	}
	//


	/*QUESTION 8*/
	var w8h8 = document.getElementById("wrapper8").querySelector("h1");
	var formMessages8 = document.getElementById("form-messages8");
	var inputAQ8Label = document.getElementById("wrapper8").querySelector("form").querySelector("div:nth-child(1)").querySelector("label");
	var inputBQ8Label = document.getElementById("wrapper8").querySelector("form").querySelector("div:nth-child(2)").querySelector("label");
	var inputCQ8Label = document.getElementById("wrapper8").querySelector("form").querySelector("div:nth-child(3)").querySelector("label");
	var inputDQ8Label = document.getElementById("wrapper8").querySelector("form").querySelector("div:nth-child(4)").querySelector("label");
	var inputAQ8Input = document.getElementById("wrapper8").querySelector("form").querySelector("div:nth-child(1)").querySelector("input");
	var inputBQ8Input = document.getElementById("wrapper8").querySelector("form").querySelector("div:nth-child(2)").querySelector("input");
	var inputCQ8Input = document.getElementById("wrapper8").querySelector("form").querySelector("div:nth-child(3)").querySelector("input");
	var inputDQ8Input = document.getElementById("wrapper8").querySelector("form").querySelector("div:nth-child(4)").querySelector("input");

	w8h8.innerHTML = questions.allQuestions[14].question;
	inputAQ8Label.innerHTML = questions.allQuestions[15].selections.A;
	inputBQ8Label.innerHTML = questions.allQuestions[15].selections.B;
	inputCQ8Label.innerHTML = questions.allQuestions[15].selections.C;
	inputDQ8Label.innerHTML = questions.allQuestions[15].selections.D;

	var questionEight = function()
	{
		if (inputAQ8Input.value === "" && inputBQ8Input.value === "" && inputCQ8Input.value === "" && inputDQ8Input.value === "")
		{
			alert("You must enter A, B, C or D for question 8!");
			return false;
		}

		if (inputDQ8Input.value == "D" || inputDQ8Input.value == "d")
		{
			formMessages8.innerHTML = "Correct";
			inputAQ8Input.value = "";
			inputBQ8Input.value = "";
			inputCQ8Input.value = "";
			inputDQ8Input.value = "";
			inputAQ8Input.disabled = true;
			inputBQ8Input.disabled = true;
			inputCQ8Input.disabled = true;
			inputDQ8Input.disabled = true;
			score++;
			formMessages11.innerHTML = "You got " + score + " out of " + total + ".";
			return false;
		}

		else
		{
			formMessages8.innerHTML = "Wrong";
			inputAQ8Input.value = "";
			inputBQ8Input.value = "";
			inputCQ8Input.value = "";
			inputDQ8Input.value = "";
			inputAQ8Input.disabled = true;
			inputBQ8Input.disabled = true;
			inputCQ8Input.disabled = true;
			inputDQ8Input.disabled = true;
			return false;
		}
	}
	//


	/*QUESTION 9*/
	var w9h9 = document.getElementById("wrapper9").querySelector("h1");
	var formMessages9 = document.getElementById("form-messages9");
	var inputAQ9Label = document.getElementById("wrapper9").querySelector("form").querySelector("div:nth-child(1)").querySelector("label");
	var inputBQ9Label = document.getElementById("wrapper9").querySelector("form").querySelector("div:nth-child(2)").querySelector("label");
	var inputCQ9Label = document.getElementById("wrapper9").querySelector("form").querySelector("div:nth-child(3)").querySelector("label");
	var inputDQ9Label = document.getElementById("wrapper9").querySelector("form").querySelector("div:nth-child(4)").querySelector("label");
	var inputAQ9Input = document.getElementById("wrapper9").querySelector("form").querySelector("div:nth-child(1)").querySelector("input");
	var inputBQ9Input = document.getElementById("wrapper9").querySelector("form").querySelector("div:nth-child(2)").querySelector("input");
	var inputCQ9Input = document.getElementById("wrapper9").querySelector("form").querySelector("div:nth-child(3)").querySelector("input");
	var inputDQ9Input = document.getElementById("wrapper9").querySelector("form").querySelector("div:nth-child(4)").querySelector("input");

	w9h9.innerHTML = questions.allQuestions[16].question;
	inputAQ9Label.innerHTML = questions.allQuestions[17].selections.A;
	inputBQ9Label.innerHTML = questions.allQuestions[17].selections.B;
	inputCQ9Label.innerHTML = questions.allQuestions[17].selections.C;
	inputDQ9Label.innerHTML = questions.allQuestions[17].selections.D;

	var questionNine = function()
	{
		if (inputAQ9Input.value === "" && inputBQ9Input.value === "" && inputCQ9Input.value === "" && inputDQ9Input.value === "")
		{
			alert("You must enter A, B, C or D for question 9!");
			return false;
		}

		if (inputAQ9Input.value == "A" || inputAQ9Input.value == "a")
		{
			formMessages9.innerHTML = "Correct";
			inputAQ9Input.value = "";
			inputBQ9Input.value = "";
			inputCQ9Input.value = "";
			inputDQ9Input.value = "";
			inputAQ9Input.disabled = true;
			inputBQ9Input.disabled = true;
			inputCQ9Input.disabled = true;
			inputDQ9Input.disabled = true;
			score++;
			formMessages11.innerHTML = "You got " + score + " out of " + total + ".";
			return false;
		}

		else
		{
			formMessages9.innerHTML = "Wrong";
			inputAQ9Input.value = "";
			inputBQ9Input.value = "";
			inputCQ9Input.value = "";
			inputDQ9Input.value = "";
			inputAQ9Input.disabled = true;
			inputBQ9Input.disabled = true;
			inputCQ9Input.disabled = true;
			inputDQ9Input.disabled = true;
			return false;
		}
	}
	//


	/*QUESTION 10*/
	var w10h10 = document.getElementById("wrapper10").querySelector("h1");
	var formMessages10 = document.getElementById("form-messages10");
	var inputAQ10Label = document.getElementById("wrapper10").querySelector("form").querySelector("div:nth-child(1)").querySelector("label");
	var inputBQ10Label = document.getElementById("wrapper10").querySelector("form").querySelector("div:nth-child(2)").querySelector("label");
	var inputCQ10Label = document.getElementById("wrapper10").querySelector("form").querySelector("div:nth-child(3)").querySelector("label");
	var inputDQ10Label = document.getElementById("wrapper10").querySelector("form").querySelector("div:nth-child(4)").querySelector("label");
	var inputAQ10Input = document.getElementById("wrapper10").querySelector("form").querySelector("div:nth-child(1)").querySelector("input");
	var inputBQ10Input = document.getElementById("wrapper10").querySelector("form").querySelector("div:nth-child(2)").querySelector("input");
	var inputCQ10Input = document.getElementById("wrapper10").querySelector("form").querySelector("div:nth-child(3)").querySelector("input");
	var inputDQ10Input = document.getElementById("wrapper10").querySelector("form").querySelector("div:nth-child(4)").querySelector("input");

	w10h10.innerHTML = questions.allQuestions[18].question;
	inputAQ10Label.innerHTML = questions.allQuestions[19].selections.A;
	inputBQ10Label.innerHTML = questions.allQuestions[19].selections.B;
	inputCQ10Label.innerHTML = questions.allQuestions[19].selections.C;
	inputDQ10Label.innerHTML = questions.allQuestions[19].selections.D;

	var questionTen = function()
	{
		if (inputAQ10Input.value === "" && inputBQ10Input.value === "" && inputCQ10Input.value === "" && inputDQ10Input.value === "")
		{
			alert("You must enter A, B, C or D for question 10!");
			return false;
		}

		if (inputCQ10Input.value == "C" || inputCQ10Input.value == "c")
		{
			formMessages10.innerHTML = "Correct";
			inputAQ10Input.value = "";
			inputBQ10Input.value = "";
			inputCQ10Input.value = "";
			inputDQ10Input.value = "";
			inputAQ10Input.disabled = true;
			inputBQ10Input.disabled = true;
			inputCQ10Input.disabled = true;
			inputDQ10Input.disabled = true;
			score++;
		
			if(score >= 7)
			{
				formMessages11.innerHTML = "YOU WIN!! You got " + score + " out of " + total + ".";
				inputAQ10Input.value = "";
				inputBQ10Input.value = "";
				inputCQ10Input.value = "";
				inputDQ10Input.value = "";
				inputAQ10Input.disabled = true;
				inputBQ10Input.disabled = true;
				inputCQ10Input.disabled = true;
				inputDQ10Input.disabled = true;
				return false;
			}
		}
		
		if(score <= 6)
		{
			formMessages11.innerHTML = "You Lose. You got " + score + " out of " + total + ".";
			inputAQ10Input.value = "";
			inputBQ10Input.value = "";
			inputCQ10Input.value = "";
			inputDQ10Input.value = "";
			inputAQ10Input.disabled = true;
			inputBQ10Input.disabled = true;
			inputCQ10Input.disabled = true;
			inputDQ10Input.disabled = true;
			return false;
		}

		else
		{
			formMessages10.innerHTML = "Wrong";
			inputAQ10Input.value = "";
			inputBQ10Input.value = "";
			inputCQ10Input.value = "";
			inputDQ10Input.value = "";
			inputAQ10Input.disabled = true;
			inputBQ10Input.disabled = true;
			inputCQ10Input.disabled = true;
			inputDQ10Input.disabled = true;
			
			if(score >= 7)
			{
				formMessages11.innerHTML = "YOU WIN!! You got " + score + " out of " + total + ".";
				inputAQ10Input.value = "";
				inputBQ10Input.value = "";
				inputCQ10Input.value = "";
				inputDQ10Input.value = "";
				inputAQ10Input.disabled = true;
				inputBQ10Input.disabled = true;
				inputCQ10Input.disabled = true;
				inputDQ10Input.disabled = true;
				return false;
			}
		}
	}
	}
	//