var charName = "";

function getPlayerName() {
    do {
        charName = prompt("What is your character's name?", "");
        if (charName == null || charName == "") {
            alert("You did not enter a valid name. Try again.");
        }
    }
    while (charName == null || charName == "");
    document.getElementById("welcome").hidden = true;
    document.getElementById("nameButton").hidden = true;
    document.getElementById("printName").innerHTML = "Hello " + charName;
    document.getElementById("left").hidden = false;
    document.getElementById("right").hidden = false;
    document.getElementById("up").hidden = false;
    document.getElementById("down").hidden = false;
    document.getElementById("displayInventory").hidden = false;
}

function moveRight() {

}

function moveLeft() {

}

function moveUp() {

}

function moveDown() {

}

function displayInv() {
    document.getElementById("printName").innerHTML = "hi";
    document.getElementById("left").hidden = true;
    document.getElementById("right").hidden = true;
    document.getElementById("up").hidden = true;
    document.getElementById("down").hidden = true;
    document.getElementById("displayInventory").hidden = true;
    document.getElementById("closeInventory").hidden = false;
    //display all inventory
}

function closeInv() {
    document.getElementById("left").hidden = false;
    document.getElementById("right").hidden = false;
    document.getElementById("up").hidden = false;
    document.getElementById("down").hidden = false;
    document.getElementById("displayInventory").hidden = false;
    document.getElementById("closeInventory").hidden = true;
}

function loadGame() {

}