
async function AddBird() {
    let response = await fetch("observation", {
        method: "POST",
        body: JSON.stringify({
            name: document.getElementById("inputAddBird").value,

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
}

async function ShowAllBirds() {
    let response = await fetch("observation/GetAllBirds")
    if (response.status === 200) {
        let birds = await response.json();
        console.log("birds")

        for (let bird of birds) {
            document.getElementById("divForBirds").innerHTML += `
            ${bird.name} <br>
                `
        }
    }
    else {
        alert("Något gick snett med att visa fåglarna")
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
