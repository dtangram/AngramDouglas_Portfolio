//TIRE PRESSURE
var tirePressure = [32, 32, 32, 32];

var formMessages1 = document.getElementById("form-messages1");
var newInputFL = document.getElementById("FLTire");
var newInputFR = document.getElementById("FRTire");
var newInputRL = document.getElementById("RLTire");
var newInputRR = document.getElementById("RRTire");

var tireSpec = function()
{
	if (newInputFL.value === "" || newInputFR.value === "" || newInputRL.value === "" || newInputRR.value === "")
	{
		alert("You must enter a number!");
		return false;
	}
	
	if (newInputFL.value == tirePressure[0] && newInputFR.value == tirePressure[1] && newInputRL.value == tirePressure[2] && newInputRR.value == tirePressure[3])
	{
		formMessages1.innerHTML = "The tires pass spec!";
		newInputFL.focus();
		newInputFL.value = "";
		newInputFR.value = "";
		newInputRL.value = "";
		newInputRR.value = "";
		return false;
	}
	
	else if (newInputFL.value != tirePressure[0] && newInputFR.value != tirePressure[1] && newInputRL.value != tirePressure[2] && newInputRR.value != tirePressure[3])
	{
		formMessages1.innerHTML = "Get your tires checked out!";
		newInputFL.focus();
		newInputFL.value = "";
		newInputFR.value = "";
		newInputRL.value = "";
		newInputRR.value = "";
		return false;
	}
}
//


//CHARGE IT!!
var newInputMax = document.getElementById("newInputMax");
var purchase = document.getElementById("purchase");
var formMessages2 = document.getElementById("form-messages2");
var labelCreditMax = document.getElementById("wrapper2").querySelector("form").querySelector("div").querySelector("label");

labelCreditMax.innerHTML = "Please enter your max line of credit.";

var charge = function()
{
	if (newInputMax.value === "" || purchase.value === "")
	{
		alert("You must enter a number!");
		return false;
	}
	
	var newTotalMax = (newInputMax.value - purchase.value);
	
	if (newInputMax.value == purchase.value && newInputMax.value != "" && purchase.value != "")
	{
		labelCreditMax.innerHTML = "Please enter your max line of credit.";
		formMessages2.innerHTML = "You have reached your limit. Your balance is $" + newTotalMax + ".";
		newInputMax.disabled = false;
		newInputMax.focus();
		newInputMax.value = "";
		purchase.value = "";
		return false;
	}
	
	if (newTotalMax < purchase.value && newInputMax.value < purchase.value || newTotalMax < 0 || newInputMax.value < 0)
	{
		labelCreditMax.innerHTML = "Please enter your max line of credit.";
		formMessages2.innerHTML = "You have exceeded your limit. Your balance is $" + newTotalMax + ".";
		newInputMax.disabled = false;
		newInputMax.focus();
		newInputMax.value = "";
		purchase.value = "";
		newInputMax.disabled = false;
		return false;
	}
	
	else
	{
		labelCreditMax.innerHTML = "Your new max credit line.";
		formMessages2.innerHTML = "From your current purchase of $" + purchase.value + " you can still spend $" + newTotalMax + ".";
		newInputMax.value = newTotalMax;
		newInputMax.disabled = true;
		purchase.focus();
		purchase.value = "";
	}
}
//


//MOVIE TICKET PRICE
var priceOne = 12;
var priceTwo = 7;
var newAge = document.getElementById("newAge");
var newTime = document.getElementById("newTime");
var formMessages3 = document.getElementById("form-messages3");

var ticketPrice = function()
{
	if (newAge.value === "" || newTime.value === "")
	{
		alert("You must enter a number!");
		return false;
	}
	
	if (newAge.value >= 55 || newAge.value <= 10 || newTime.value >= 4 && newTime.value <= 7)
    {
    	formMessages3.innerHTML = "The ticket price is $" + priceTwo + ".";
		newAge.focus();
		newAge.value = "";
		newTime.value = "";
		return false;
	}
    
    else
    {
    	formMessages3.innerHTML = "The ticket price is $" + priceOne + ".";
		newAge.focus();
		newAge.value = "";
		newTime.value = "";
		return false;
    }
}
//


//TEMPERATURE CONVERTER
var temp = document.getElementById("temp");
var fc = document.getElementById("fc");
var fahr = document.getElementById("fahr");
var cel = document.getElementById("cel");
var fahrenheit = "F";
var lowerF = "f";
var lowerC = "c";
var celsius = "C";
var formMessages4 = document.getElementById("form-messages4");

var tempConvert = function()
{
	if (fc.value === "" || temp.value === "")
	{
		alert("You cannot leave blank!");
		return false;
	}
	
    var fahrenConvert = ((temp.value - 32) * 5 / 9);
    var celsConvert = ((temp.value * 9 / 5) + 32);
	
	if (fc.value == fahrenheit || fc.value == lowerF)
    {
		formMessages4.innerHTML = "The temperature is " + temp.value + " degrees " + fahrenheit + ".";
    }

    if (fc.value == celsius || fc.value == lowerC)
    {
     	formMessages4.innerHTML = "The temperature is " + temp.value + " degrees " + celsius + ".";
    }

    if (cel.value == lowerC || cel.value == celsius)
    {
		formMessages4.innerHTML = "The temperature is " + fahrenConvert + " degrees " + celsius + ".";
		temp.focus();
		temp.value = "";
		fc.value = "";
		cel.value = "";
		return false;
    }

    if (fahr.value == fahrenheit || fahr.value == lowerF)
    {
		formMessages4.innerHTML = "The temperature is " + fahrenConvert + " degrees " + fahrenheit + ".";
		temp.focus();
		temp.value = "";
		fc.value = "";
		fahr.value = "";
		return false;
    }
}
//


//LETTER GRADE CALCULATOR
var gradeInput = document.getElementById("gradeInput");
var gradeA = "an A";
var gradeB = "a B";
var gradeC = "a C";
var gradeD = "a D";
var gradeF = "an F";
var formMessages5 = document.getElementById("form-messages5");

var gradeCalc = function()
{
	if (gradeInput.value === "")
	{
		alert("You cannot leave blank!");
		return false;
	}
	
	if (gradeInput.value <= 100 && gradeInput.value >= 90)
    {
		formMessages5.innerHTML = "You made " + gradeInput.value + "% for your grade, which means you made " + gradeA + ".";
		gradeInput.focus();
		gradeInput.value = "";
		return false;
    }

	else if(gradeInput.value <= 89 && gradeInput.value >= 80)
    {
		formMessages5.innerHTML = "You made " + gradeInput.value + "% for your grade, which means you made " + gradeB + ".";
		gradeInput.focus();
		gradeInput.value = "";
		return false;
    }

    else if(gradeInput.value <= 79 && gradeInput.value >= 73)
    {
		formMessages5.innerHTML = "You made " + gradeInput.value + "% for your grade, which means you made " + gradeC + ".";
		gradeInput.focus();
		gradeInput.value = "";
		return false;
    }

	else if(gradeInput.value <= 72 && gradeInput.value >= 70)
    {
		formMessages5.innerHTML = "You made " + gradeInput.value + "% for your grade, which means you made " + gradeD + ".";
		gradeInput.focus();
		gradeInput.value = "";
		return false;
    }
	
	else if(gradeInput.value <= 69 && gradeInput.value >= 0)
	{
		formMessages5.innerHTML = "You made " + gradeInput.value + "% for your grade, which means you made " + gradeF + ".";
		gradeInput.focus();
		gradeInput.value = "";
		return false;
    }
}
//


//REVERSE IT
var item1 = document.getElementById("item1");
var item2 = document.getElementById("item2");
var item3 = document.getElementById("item3");
var item4 = document.getElementById("item4");
var item5 = document.getElementById("item5");

var reverseIt = function()
{
	var itemsInArray = [item1.value, item2.value, item3.value, item4.value, item5.value];
	
	if (item1.value === "" || item2.value === "" || item3.value === "" || item4.value === "" || item5.value === "")
	{
		alert("You cannot leave blank!");
		return false;
	}
	
	for (var i = itemsInArray.length - 1; i >= 0; i--)
	{
		alert("Your original array is " + itemsInArray + ". Your reverse array is " + itemsInArray[i] + ".");
	}
	
	item1.focus();
	item1.value = "";
	item2.value = "";
	item3.value = "";
	item4.value = "";
	item5.value = "";
}
//