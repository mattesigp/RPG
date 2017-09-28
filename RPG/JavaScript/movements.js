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

function right() {

}

function left() {

}

function up() {

}

function down() {

}

function loadGame() {

}