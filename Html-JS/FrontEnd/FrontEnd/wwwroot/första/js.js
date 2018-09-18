document.getElementById("minKnapp").addEventListener("click", function() {
	document.getElementById("minRubrik").innerHTML = "Bla bla bl";
	var x = document.getElementById("bild");
	if (x.style.display == "none"){
		x.style.display = "block";
	} else {
		x.style.display = "none";
	}
});
var button = document.getElementById("minKnapp2"), count = 0;
function rakna ()
{
	if (count == 20)
	{
		button.innerHTML = "Skaffa dig ett liv ";
	}else {
			count+=1;
	console.log(count)
	button.innerHTML = "Click meee: " + count;
	}

};