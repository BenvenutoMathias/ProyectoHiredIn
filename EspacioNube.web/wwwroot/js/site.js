

$("a").addClass("nav-link");
let estado = true;


const CambiarTema = () => {
  
  if (estado) {
    $("#Tema").text("Claro");
    $("#Tema").removeClass("btn-dark").addClass("btn-light");
    /* $("a:not('.not')").removeClass("text-dark").addClass("text-light"); */
    /* $("#Cuerpo").removeClass("bodyWhite").addClass("bodyDark"); */
    $('#render').removeClass("bodyWhite").addClass("bodyDark");
    $("table").addClass("table-dark");
    $(".MIMODAL").css("color","black");
    estado = false;
  } else {
    
    $("#Tema").text("Oscuro");
    $("#Tema").removeClass("btn-light").addClass("btn-dark");
      /* $("a:not('.not')").removeClass("text-light").addClass("text-dark"); */
      /* $("#Cuerpo").removeClass("bodyDark").addClass("bodyWhite"); */
      $('#render').removeClass("bodyDark").addClass("bodyWhite");
      $("table").removeClass("table-dark");
      
      estado = true;
  }
};