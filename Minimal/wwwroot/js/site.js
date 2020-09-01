// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(function() {
    menuClick();
});

function menuClick(){
    $(".ham").click(() => {
        $(".ham").toggleClass('active');
        $(".body").toggleClass('menu-open');
    })

    $(".menu-overlay").click(() => {
        $(".ham").toggleClass('active');
        $(".body").toggleClass('menu-open');
    })
};

ShowInPopup = (url, title) => {
    $.ajax({
        type: "GET",
        url: url,
        success: function(res){
            $(".modal .modal-content").html(res);
            $(".modal .modal-title").html(title);
        }
    })
}