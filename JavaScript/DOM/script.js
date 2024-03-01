var button = document.getElementById("enter");
var editButton = document.getElementById("edit")
var input = document.getElementById("userinput");
var ul = document.querySelector("ul");
var getItDoneToday = document.getElementById("first")



function rmDelButton(){
	input.disabled = false
	var delButton = document.querySelectorAll('.delButton')

	for(var i=0; i<delButton.length; i++){
		delButton[i].remove()
	}
}


var editList = function() {


	input.disabled = true



	if(document.getElementsByTagName("li")[0].children.length === 1){
		var allDelButton = document.querySelectorAll(".delButton")
		var li = document.getElementsByTagName("li")

		for(var index =0; index<li.length; index++){
			li[index].removeEventListener("click", allDelButton[index].remove)
	}


		rmDelButton()
		return
	}

	var li = document.getElementsByTagName("li")

	for(var i=0; i<li.length; i++){

		var delButton = document.createElement("input")
		delButton.type = "button"
		delButton.value = "X"
		delButton.className = "delButton"
		delButton.id ="delButton"+i
		li[i].append(delButton)
	}

	var allDelButton = document.querySelectorAll(".delButton")

	li[0].addEventListener("click", allDelButton[0].remove)
	li[1].addEventListener("click", allDelButton[1].remove)
	li[2].addEventListener("click", allDelButton[2].remove)
	li[3].addEventListener("click", allDelButton[3].remove)
	li[4].addEventListener("click", allDelButton[4].remove)
	li[5].addEventListener("click", allDelButton[5].remove)
	li[6].addEventListener("click", allDelButton[6].remove)
	li[7].addEventListener("click", allDelButton[7].remove)
	li[8].addEventListener("click", allDelButton[8].remove)
	li[9].addEventListener("click", allDelButton[9].remove)
	li[10].addEventListener("click", allDelButton[10].remove)




}




function inputLength() {
	return input.value.length;
}


function createListElement() {
	var liMax = document.getElementsByTagName("li")
	if(liMax.length ===12){alert("Hai raggiunto il limite massimo della lista!"); return}
	var li = document.createElement("li");
	li.appendChild(document.createTextNode(input.value));
	ul.appendChild(li);
	input.value = "";
}

function addListAfterClick() {
	if (inputLength() > 0) {
		createListElement();
	}
}

function addListAfterKeypress(event) {
	if (inputLength() > 0 && event.keyCode === 13) {
		createListElement();
	}
}

function toOnOffUl() {


    switch(ul.style.display){
        case "none": ul.style.display = ""; editButton.style.display = ""; input.disabled = false
            break
        default: ul.style.display = "none"; editButton.style.display = "none"; input.disabled = true; rmDelButton()
    }

}



editButton.addEventListener("click", editList)

button.addEventListener("click", addListAfterClick);

input.addEventListener("keypress", addListAfterKeypress);

getItDoneToday.addEventListener("click", toOnOffUl);


