// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

function DivDistChange(selectObj) {
    var idx = selectObj.selectedIndex;
    var which = selectObj.options[idx].value;
    cList = DivDist[which];
    var cSelect = document.getElementById("district");
    var len = cSelect.options.length;
    while (cSelect.options.length > 0) {
        cSelect.remove(0);
    }
    var newOption;
    // create new options
    for (var i = 0; i < cList.length; i++) {
        newOption = document.createElement("option");
        newOption.value = cList[i];  // assumes option string and value are the same
        newOption.text = cList[i];
        // add the new option
        //try {
        //    cSelect.add(newOption);  // this will fail in DOM browsers but is needed for IE
        //}
        //catch (e) {
        cSelect.appendChild(newOption);
        //}

    }
    DistThanaChange(cSelect);
}

function DistThanaChange(selectObj) {
    // get the index of the selected option
    var idx = selectObj.selectedIndex;
    // get the value of the selected option
    var which = selectObj.options[idx].value;
    // use the selected option value to retrieve the list of items from the DivDist array
    cList = DistThana[which];
    // get the country select element via its known id
    var cSelect = document.getElementById("thana");
    // remove the current options from the country select
    var len = cSelect.options.length;
    while (cSelect.options.length > 0) {
        cSelect.remove(0);
    }
    var newOption;
    // create new options
    for (var i = 0; i < cList.length; i++) {
        newOption = document.createElement("option");
        newOption.value = cList[i];  // assumes option string and value are the same
        newOption.text = cList[i];
        // add the new option
        cSelect.appendChild(newOption);
    }
    ThanaUWChange(cSelect);
}

function ThanaUWChange(selectObj) {
    // get the index of the selected option
    var idx = selectObj.selectedIndex;
    // get the value of the selected option
    var which = selectObj.options[idx].value;
    // use the selected option value to retrieve the list of items from the DivDist array
    cList = Dict[which];
    // get the country select element via its known id
    var cSelect = document.getElementById("uw");
    // remove the current options from the country select
    var len = cSelect.options.length;
    while (cSelect.options.length > 0) {
        cSelect.remove(0);
    }
    var newOption;
    // create new options
    for (var i = 0; i < cList.length; i++) {
        newOption = document.createElement("option");
        newOption.value = cList[i];  // assumes option string and value are the same
        newOption.text = cList[i];
        // add the new option
        cSelect.appendChild(newOption);
    }
}