async function ValidateBird() {
    let response = await fetch("observation/GetAllBirds")
    let nameOfBird = document.getElementById("inputAddName").value;
    let dateOfBird = document.getElementById("inputAddDate").value;
    let locationOfBird = document.getElementById("inputAddLocation").value;
    if (response.status === 200) {
        let birds = await response.json();
        let sameDayAndName = false;
        for (let bird of birds) {

            let birdRealDate = new Date(bird.date);
            let dateOfBirdRealDate = new Date(dateOfBird);


            let formatedDate = formatDate(bird.date)
            if (bird.name === nameOfBird && birdRealDate.getYear().valueOf() === dateOfBirdRealDate.getYear().valueOf() && bird.location === locationOfBird) {
                if (birdRealDate.getMonth().valueOf() === dateOfBirdRealDate.getMonth().valueOf()) {
                    if (birdRealDate.getDay().valueOf() === dateOfBirdRealDate.getDay().valueOf()) {
                        sameDayAndName = true;
                        break;
                    }
                }
            }
        }
        return !sameDayAndName;
    }
    else {
        alert("gick inte att hämta fåglarna: validatebird")
    }
}

async function Validate() {
    
  
    if (await ValidateBird()) {
        AddBird();
    }
    else
        if(confirm("Finns redan en fågel denna dag och plats, vill du ändå lägga till?!")){
        AddBird();
    }
}
async function AddBird() {

        let response = await fetch("observation", {
            method: "POST",
            body: JSON.stringify({
                name: document.getElementById("inputAddName").value,
                location: document.getElementById("inputAddLocation").value,
                date: document.getElementById("inputAddDate").value,
                notes: document.getElementById("inputAddNotes").value,
            }),
            headers: {
                "Content-Type": "application/json"
            }
        });

        if (response.status === 200) {
            let id = await response.json();
            console.log(`News with id = ${id} added`);

        } else {
            console.log("Unexpected error", await response.text());
        }
        resetTable()
        ShowAllBirds()
    
   
}
async function resetTable() {
    document.getElementById("table").innerHTML = "";
}

function formatDate(d) {
    if (!d) return "";
    d = new Date(d);
    return d.toLocaleDateString() + " " + d.toLocaleTimeString();
}

async function ShowAllBirds() {
    let response = await fetch("observation/GetAllBirds")
    if (response.status === 200) {
        let birds = await response.json();

        birds.sort(function (a, b) {
            var c = new Date(a.date)
            var d = new Date(b.date)
            return c - d;
        });

        for (let bird of birds) {
            document.getElementById("table").innerHTML += `<tr>
                <td>${bird.name}</td>
                <td>${formatDate(bird.date)}</td>
                <td>${bird.location}</td>
                <td>${bird.notes}</td>
                 </tr>`
        }
    }
    else {
        alert("Något gick snett med att visa fåglarna")
    }
}
async function ShowAllSpecies() {
    let response = await fetch("observation/GetAllBirds")
    let species = [];
    if (response.status === 200) {
        let birds = await response.json();
        for (let bird of birds) {
            if (!species.includes(`${bird.name.toLowerCase()}`)) {
                species.push(bird.name.toLowerCase());
            }
        }
    }
    else {
        alert("gick inte att hämta fåglarna")
    }
    species.sort();
    for (let name of species) {
        document.getElementById("species").innerHTML += `
                ${name}<br>
                `
    }
}


async function recreateDatabase() {
    document.getElementById("recreateButton").style.display = "none";
    document.body.style.backgroundColor = "blue";

    let response = await fetch("/observation/recreate", {
        method: "POST"
    });

    if (response.status === 200) {
        document.getElementById("recreateButton").style.display = "block";
        document.body.style.backgroundColor = "green";

    } else {
        document.getElementById("recreateButton").style.display = "block";
        document.body.style.backgroundColor = "red";

    }

}
