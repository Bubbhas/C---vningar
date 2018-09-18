arr8()

//Andra delen

function arr8(){
	let numbers = [5,66,777,12]
	numbers.reverse()
	console.log(numbers)

}

function arr7(){
	let numbers = [5,66,777,12]
	numbers.sort();
	console.log(numbers)
	numbers.sort((a,b) => b-a);
	console.log(numbers)
}

function arr6(){
	let numbers = [5,66,777,12]
	numbers.sort();
	console.log(numbers)
	numbers.sort((a,b) => a-b);
	console.log(numbers)
}

function arr5(){
	let numbers = [5,66,777,12]
	console.log(numbers.length)

	console.log(numbers[2])
}

function arr4(){
	let cities = ["Stockholm", "Göteborg", "new York"]
	let poppedCity = cities.pop();
	console.log(cities.length);
	console.log(poppedCity);
	console.log(cities[cities.length-1])
}
function arr3(){
	let cities = ["Stockholm", "Göteborg", "new York", "Helsingfors"]
	console.log(cities[0]);
	console.log(cities[1]);
	console.log(cities[2]);
	console.log(cities[3]);
	cities.push("Krakow");
	cities.push("Berlin");
	console.log("Det finns " + cities.length + " i arrayen");
	console.log("mina favoritstäder " + cities[1] +" och " + cities[4]);
}

function arr2(){
	let cities = ["Stockholm", "Göteborg", "new York", "Helsingfors"]
	console.log(cities[0]);
	console.log(cities[1]);
	console.log(cities[2]);
	console.log(cities[3]);
	cities.push("Krakow");
	console.log(cities[4]);
	console.log(cities);
}

function arr1(){
	let cities = ["Stockholm", "Göteborg", "new York"]
	console.log(cities[0]);
	console.log(cities[1]);
	console.log(cities[2]);
console.log(cities[3]);
}

//Första delen
function var1(){
	console.log("Jag heter jesper")
}
function var2(){
	let tal = 35
	console.log(tal)
}
function var3(){
	let x = 12
	let y = 6
	let z = x + y
	console.log(z)
}
function var4(){
	let x = 77
	let y = 44
	x = 55
	let z = x + y
	console.log(z)
}
function var6(){
	let nummer1 = "77"
	let nummer2 = "50"
	let z = nummer1 + nummer2
	console.log(z)
}
function var7(){
	let nummer1 = "77"
	let nummer2 = 50
	let z = parseInt(nummer1) + nummer2
	console.log(z)
}
function var8(){
	let nummer1 = 42
	if (nummer1 === 42)
	{
	console.log("Mitt favorittal är " + nummer1)	
	}
}
function var9(){
	let nummer1 = 42
	if (nummer1 === 42)
	{
	console.log(`Mitt favorittal är  ${nummer1}`)	
	}
}
function var10(){
	let x = 12
	let y = true
	let z = "måndag"
	let w

	console.log(typeof(x))	
	console.log(typeof(y))	
	console.log(typeof(z))	
	console.log(typeof(w))	
}
function var11(){
	let x = parseInt("oscar")
	let y = isNaN(x)
	console.log(y)
	
}

