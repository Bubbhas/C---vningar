let x = byId("addfield");
x.style.display = "none";

let y = byId("statistics");
y.style.display = "none";

let update = byId("uppdatefield");
update.style.display = "none";

async function addNews() {
    if (byId("addformHeader").value === "" || byId("addformIntro").value === "" || byId("addformBody").value === "") {
        alert("Client: Du måste fylla i alla fält")
    } else if (byId("addformHeader").value.length < 5 || byId("addformHeader").value.length > 20) {
        alert("Client: Måste vara mellan 5-20 tecken")
    }
    else {
        let response = await fetch("api/News", {
            method: "POST",
            body: JSON.stringify({
                header: byId("addformHeader").value,
                intro: byId("addformIntro").value,
                body: byId("addformBody").value,

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
        getAll()
    }
}

async function Delete(id) {

    let response = await fetch(`api/News/${id}`, {
        method: "DELETE"
    });

    if (response.status === 200) {
        
        console.log("Deleten gick bra");

    } else {
        console.log("Unexpected error with the delete", response);
    }
    resetTable()
    getAll()
}
async function Seed() {
    let response = await fetch("api/news/GetAll")
    let News = await response.json();
    for (let item of News) {
        let response = await fetch(`api/News/${item.id}`, {
            method: "DELETE"
        });
    }
    let response2 = await fetch("api/News", {
        method: "POST",
        body: JSON.stringify({
            header: "FörstaDedfault",
            intro: "FörstaDedfault",
            body: "FörstaDedfault",
        }),
        headers: {
            "Content-Type": "application/json"
        }
    });

    let response3 = await fetch("api/News", {
        method: "POST",
        body: JSON.stringify({
            header: "AndraDedfault",
            intro: "AndraDedfault",
            body: "AndraDedfault",
        }),
        headers: {
            "Content-Type": "application/json"
        }
    });
    resetTable()
    getAll()
}

async function UpdateNews() {

    if (byId("updateformHeader").value === "" || byId("updateformIntro").value === "" || byId("updateformBody").value === "") {
        alert("Client: Du måste fylla i alla fält")
    } else if (byId("updateformHeader").value.length < 5 || byId("updateformHeader").value.length > 20) {
        alert("Client: Måste vara mellan 5-20 tecken")
    }
    else {
        let response = await fetch("api/News", {
            method: "PUT",
            body: JSON.stringify({
                id: byId("UpdateId").value,
                created: byId("updateCreated").value,
                header: byId("updateformHeader").value,
                intro: byId("updateformIntro").value,
                body: byId("updateformBody").value,
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
        getAll()
    }
}

async function resetTable() {
    byId("table").innerHTML = "";

}
async function AddNewsFields() {
    if (x.style.display === "none") {
        x.style.display = "block";
        update.style.display = "none";
    }
    else 
    x.style.display = "none";
}

async function ShowUpdate(id, header, intro, body, created) {

    if (update.style.display === "none") {
        x.style.display = "none";
        update.style.display = "block";
        byId("UpdateId").value = id;
        byId("updateformHeader").value = header;
        byId("updateformIntro").value = intro;
        byId("updateformBody").value = body;
        byId("updateCreated").value = created;
    } else update.style.display = "none"
    
}

async function GetId(id) {
    let response = await fetch("api/news/id")
    if (response.status === 200) {
        let Id = await response.json();
        return response;
    }else alert("fel på getID")

}

async function Statistics() {
    if (y.style.display === "none") {
        y.style.display = "block";
        x.style.display = "none";
        update.style.display = "none";
        let response = await fetch("api/news/count")
        if (response.status === 200) {
            let News = await response.json();
            byId("statistics").innerHTML = `<h3>Numbers of News</h3>
            Number of news: ${News}     `
        }
    } else y.style.display = "none"
}

async function recreate() {
    // fetch "api/News/Recreate" med POST
    let response = await fetch("api/News/Recreate", {
        method: "POST"
    });

    if (response.status === 200) {
        alert("Allt gick bra")
    } else {
        alert("Något gick fel")
        console.log(response)
    }
    //await response.text();
    // kolla statuskod
    resetTable()
    getAll()
}
function byId(id) {
    return document.getElementById(id);
}

function formatDate(d) {
    if (!d) return "";
    d = new Date(d);
    return d.toLocaleDateString() + " " + d.toLocaleTimeString();
}
async function getAll() {
    let response = await fetch("api/news/GetAll")
    if (response.status === 200) {
        let News = await response.json();
        console.log("News", News)

        console.log(News.header)

        for (let header of News) {
            byId("table").innerHTML += `<tr>
                <td>${header.id}</td>
                <td>${header.header}</td>
                <td>${formatDate(header.created)}</td>
                <td>${formatDate(header.updated)}</td>

                <td><button id="update" onclick="ShowUpdate(${header.id}, '${header.header}', '${header.intro}', '${header.body}', '${header.created}')" >Uppdatera</button></td>
                <td><button id="delete" onclick="Delete(${header.id})">X</button></td>
            </tr>`
        }    
    }
    else {
        alert("inte bra")
    }
    
}
