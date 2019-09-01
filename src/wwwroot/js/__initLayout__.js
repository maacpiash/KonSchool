$( document ).ready(function() {
    $('.tooltipped').tooltip();
    
    $('.sidenav').sidenav();
    
    $('.modal').modal();
    
    $('.dropdown-trigger').dropdown({
        inDuration: 300,
        outDuration: 225,
        hover: true,
        belowOrigin: true,
        alignment: 'left'
    });
});