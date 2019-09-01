$(document).ready(function() {
    $("#mapCol a").click(function() {
        var districtName = $(this).data("value");
        alert(districtName);
    });
});