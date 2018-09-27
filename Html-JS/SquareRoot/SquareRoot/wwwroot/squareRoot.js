let errorMessage = "";
let result = "";

function render() {
    document.getElementById("result").innerText = result;
    document.getElementById("error").innerText = errorMessage;
}

async function SquareRoot() {
    let number = document.getElementById("number").value;
    let number2 = document.getElementById("number2").value;

    let response = await fetch("api/squareroot?number=" + number + "&number2=" + number2);

    
   
    if (response.status === 200) {
        result = await response.json();
        errorMessage = "";

    }
    else if (response.status === 400) {
        result = "";
        errorMessage = await response.text();
    }
    else {
        result = "";
        errorMessage = "Något gick galet";
    }

    render();

}