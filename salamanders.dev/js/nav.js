function toggleNav() {
  if ( document.getElementById("myNav").style.height === "100%") {
    document.getElementById("myNav").style.height = "0%";
  }
  else {
    document.getElementById("myNav").style.height = "100%";
  }
}

function closeNav() {
  document.getElementById("myNav").style.height = "0%";
}