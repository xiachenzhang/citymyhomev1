function getUsernameAndPassword() {
    var u = document.querySelector("#username").value;
    var p = document.querySelector("#password").value;

    if (u === "monash" && p === "tp05") {
        window.location = "Home/home";
       
    } else {
        document.querySelector("#message").innerHTML = "Wrong Information";
    } 
}



