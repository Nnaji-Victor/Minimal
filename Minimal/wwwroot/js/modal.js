// Click function for show the Modal

$(".add-button").on("click", function(){
    $(".modal-mask").addClass("modal-active");
  });
  
  // Function for close the Modal
  
  function closeModal(){
    $(".modal-mask").removeClass("modal-active");
  }
  
  // Call the closeModal function on the clicks/keyboard
  
  $(".modal-close, .modal-mask").on("click", function(){
    closeModal();
  });
  
  $(document).keyup(function(e) {
    if (e.keyCode == 27) {
      closeModal();
    }
  });

  // ajax call
  