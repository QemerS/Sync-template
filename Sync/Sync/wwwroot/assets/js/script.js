// When the user scrolls down 80px from the top of the document, resize the navbar's padding and the logo's font size
window.onscroll = function() {scrollFunction()};

function scrollFunction() {
  if (document.body.scrollTop > 80 || document.documentElement.scrollTop > 80) {
    document.getElementById("navbar_top").style.padding = "0px";
    document.getElementById("navbar_top").style.boxShadow = "1px -5px 15px rgba(0, 0, 0, 0.4";
    document.getElementById("navbar_top").style.transition = "All 0.2s";

    mybutton = document.getElementById("myBtn");//up
    mybutton.style.display = "block";//up
  }else {
    document.getElementById("navbar_top").style.padding = "8px 0px";
    document.getElementById("navbar_top").style.boxShadow = "";

    mybutton = document.getElementById("myBtn");//up
    mybutton.style.display = "none";//up
  }   
}

function openCity(evt, cityName) {
  var i, tabcontent, tablinks;
  tabcontent = document.getElementsByClassName("tabcontent");
  for (i = 0; i < tabcontent.length; i++) {
    tabcontent[i].style.display = "none";
  }
  tablinks = document.getElementsByClassName("tablinks");
  for (i = 0; i < tablinks.length; i++) {
    tablinks[i].className = tablinks[i].className.replace(" active", "");
  }
  document.getElementById(cityName).style.display = "block";
  evt.currentTarget.className += " active";
}

// Get the element with id="defaultOpen" and click on it
document.getElementById("defaultOpen").click();

//up
// When the user clicks on the button, scroll to the top of the document
function topFunction() {
  document.body.scrollTop = 0; // For Safari
  document.documentElement.scrollTop = 0; // For Chrome, Firefox, IE and Opera
}
