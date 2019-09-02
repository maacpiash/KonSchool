var requestToAPI;
var konSchoolAPI = 'api';

$(document).ready(function() {
    $("#mapCol a").click(function() {
        scrollToAnalyticalResultDivision();
        requestToAPI = $.get(konSchoolAPI + '/schools/dis/' +  $(this).data("value").toUpperCase() , function (data, status) {
            console.log(data);
            console.log(status);
        });
    });
});

function scrollToAnalyticalResultDivision(){
    $('html, body').animate({
        scrollTop: $("#analyticalResults").offset().top
    }, 1000);
}