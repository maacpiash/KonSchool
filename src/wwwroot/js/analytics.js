var requestToAPI;
var konSchoolAPI = 'api';

$(document).ready(function() {
    $("#mapCol a").click(function() {
        requestToAPI = $.get(konSchoolAPI + '/schools/dis/' +  $(this).data("value").toUpperCase() , function (data, status) {
            console.log(data);
            console.log(status);
        });
    });
});