var myGlobal = "Global thing!"

function() {
    var myGlobal = "but this is local";
    document.write(myGlobal);
}
document.write(myGlobal);