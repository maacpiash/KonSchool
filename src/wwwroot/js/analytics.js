var requestToAPI;
var konSchoolAPI = 'api';

$(document).ready(function() {
    $('#analyticalResults').hide();
    
    $("#mapCol a").click(function() {
        var districtName = $(this).data("value");
        $('#analyticalResults').slideDown();
        scrollToAnalyticalResultDivision();
        
        requestToAPI = $.get(konSchoolAPI + '/schools/dis/' + districtName.toUpperCase() , function (data, status) {
            $('#_analyticalResultHeading').text("Schools of " + toTitleCase(districtName));
        });
    });
});

function scrollToAnalyticalResultDivision(){
    $('html, body').animate({
        scrollTop: $("#analyticalResults").offset().top
    }, 1000);
}

function toTitleCase(str) {
    return str.replace(
        /\w\S*/g,
        function (txt) {
            return txt.charAt(0).toUpperCase() + txt.substr(1).toLowerCase();
        }
    );
}